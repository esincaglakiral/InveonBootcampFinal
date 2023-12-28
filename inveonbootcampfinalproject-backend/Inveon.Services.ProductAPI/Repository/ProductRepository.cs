﻿using AutoMapper;
using Inveon.Services.ProductAPI.DbContexts;
using Inveon.Models.DTOs;
using Inveon.Models;
using Microsoft.EntityFrameworkCore;

namespace Inveon.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        //Constructor Injection 
        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            //gelen ProductDto nun içindeki ProductId 0 dan büyük ise güncelleme yapılacak
            if (product.ProductId > 0)
            {
                _db.Products.Update(product);
            }
            else
            {
                //0 dan böyük değilse yeni bir kayıt eklenecek

                _db.Products.Add(product);
            }
            await _db.SaveChangesAsync();
            //kayıt eklendikten sonra databaseden eklenen product objesi geriye produtcDto olarak döndürülür
            return _mapper.Map<Product, ProductDto>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                Product product = await _db.Products.FirstOrDefaultAsync(u => u.ProductId == productId);
                if (product == null)
                {
                    return false;
                }
                _db.Products.Remove(product); //delete from Product where Id=productId
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ProductWithStockData> GetProductById(int productId)
        {
            Product product = await _db.Products.Where(p => p.ProductId == productId).FirstOrDefaultAsync();
            IEnumerable<ProductStock> stocks = await _db.ProductStocks.Where(s => s.ProductId == productId).ToListAsync();
            
            ProductWithStockData productWithStockData = new ProductWithStockData
            {
                productData = product,
                stockData = stocks
            };
            return productWithStockData;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Product> productList = await _db.Products.Include(p => p.Category)
                .Include(p => p.Brand).ToListAsync();
            
            
            return _mapper.Map<List<ProductDto>>(productList);
        }
    }
}
