import React, { useEffect, useState } from 'react'
import SideBar from './SideBar'
import ProductCard from '../Common/Product/ProductCard'
import { useSelector } from "react-redux";
import { selectAllProducts } from '../../app/slices/product';

const LeftSideBar = () => {
    // Bu bileşen, sol tarafta bir filtreleme menüsü (SideBar) ve sağ tarafta ürün kartlarını içerir. 
    // randProduct fonksiyonu sayesinde sayfa numarasına göre rastgele ürünleri gösterebilirsiniz.

    const productss = useSelector(selectAllProducts)

    const [filteredProducts, setFilteredProducts] = useState(productss)
    const [page, setPage] = useState(1)
    const [brands, setBrands] = useState(null)
    const [categories, setCategories] = useState(null)

    useEffect(() => {
        // useEffect Hook'u: Ürünlerin değiştiğinde, filtreleme için 
        // kullanılan state'leri güncelleyen bir useEffect hook'u bulunmaktadır.
        setFilteredProducts(productss)
        setBrands(Array.from(new Set(productss.map(product => product.brandName))));
        setCategories(Array.from(new Set(productss.map(product => product.categoryName))));
        
    }, [productss])
    
    let allData = [...useSelector((state) => state.products.products)];



    const randProduct = (page) => {
        // randProduct Fonksiyonu: Rastgele ürünleri gösteren bir fonksiyondur. 
        // Belirli bir sayfa numarasına göre ürünleri sıralar ve sayfada gösterilen ürün sayısını ayarlar.
        if(page){
            let data = allData.sort((a, b) => 0.5 - Math.random())
            data = data.slice(0,9);
            setPage(page);
        }
    }
    console.log('products: ', productss);
    return (
        <>
            <section id="shop_main_area" className="ptb-100">
                <div className="container">
                    <div className="row">
                        <SideBar filterEvent={randProduct} 
                            products={filteredProducts} 
                            setProducts={setFilteredProducts} 
                            allProducts={productss}
                            brands={brands}
                            categories={categories}

                        
                        />
                        <div className="col-lg-9">
                            <div className="row">
                                {filteredProducts.map(data => (
                                    <div className="col-lg-4 col-md-4 col-sm-6 col-12" key={data.productId}>
                                        <ProductCard product={data} />
                                    </div>
                                ))}
                                <div className="col-lg-12">
                                    <ul className="pagination">
                                        <li className="page-item" onClick={(e) => { randProduct(page >1?page-1:0) }}>
                                            <a className="page-link" href="#!" aria-label="Previous">
                                                <span aria-hidden="true">«</span>
                                            </a>
                                        </li>
                                        <li className={"page-item "+ (page === 1?"active":null)} onClick={(e) => { randProduct(1) }}><a className="page-link" href="#!">1</a></li>
                                        <li className={"page-item "+ (page === 2?"active":null)}  onClick={(e) => { randProduct(2) }}><a className="page-link" href="#!">2</a></li>
                                        <li className={"page-item "+ (page === 3?"active":null)}  onClick={(e) => { randProduct(3) }}><a className="page-link" href="#!">3</a></li>
                                        <li className="page-item" onClick={(e) => { randProduct(page <3?page+1:0) }}>
                                            <a className="page-link" href="#!" aria-label="Next">
                                                <span aria-hidden="true">»</span>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    )
}

export default LeftSideBar
