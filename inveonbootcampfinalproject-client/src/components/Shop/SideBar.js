import React, { useEffect, useState } from 'react'
// Import Img
import search from '../../assets/img/svg/search.svg'
import { useSelector } from "react-redux";
import { selectAllProducts } from '../../app/slices/product';

// Bu bileşen, kullanıcının ürünleri fiyat, kategori, renk ve marka gibi çeşitli kriterlere göre filtrelemesine olanak tanır. 
// Filtreler değiştikçe, ürünleri filtreler ve ana bileşene filtrelenmiş ürünleri gönderir.

const SideBar = (props) => {
// minPrice: Fiyat filtresinin minimum değeri
// maxPrice: Fiyat filtresinin maksimum değeri
// currentCategory: Seçilen ürün kategorisi
// currentBrand: Seçilen marka
// currentColor: Seçilen renk

    const [minPrice, setMinPrice] = useState(0)
    const [maxPrice, setMaxPrice] = useState(5000)
    const [currentCategory, setCurrentCategory] = useState("all")
    const [currentBrand, setCurrentBrand] = useState("all")
    const [currentColor, setCurrentColor] = useState("all")

    useEffect(() => {
        // useEffect Hook'u: Filtreleme seçenekleri değiştiğinde, bu hook içinde filtreleme işlemleri gerçekleşir. 
        // Seçilen kategori, marka, renk ve fiyat aralığına göre ürünleri filtreler.
        const filteredProducts = props.allProducts.filter(prod => {
            const priceInRange = prod.price >= minPrice && prod.price <= maxPrice;
            const categoryMatch = currentCategory === "all" || prod.categoryName === currentCategory;
            const brandMatch = currentBrand === "all" || prod.brandName === currentBrand;
            const colorMatch = currentColor === "all" || prod.color === currentColor;
        
            return priceInRange && categoryMatch && brandMatch && colorMatch;
          });
        
          // Set the filtered products in the state
          props.setProducts(filteredProducts);

    }, [minPrice, maxPrice, currentColor, currentBrand, currentCategory])

    const clearFilters = () => {
        // clearFilters Fonksiyonu: Filtreleri temizleyen bir fonksiyondur. 
        // Tüm filtre değerlerini varsayılana (başlangıç değerlerine) döndürür.
        setMinPrice(0);
        setMaxPrice(5000);
        setCurrentBrand("all");
        setCurrentCategory("all");
        setCurrentColor("all")
    }
    console.log('props.categories: ', props.categories);
    console.log('props.brands: ', props.brands);
    return (
        <>
            <div className="col-lg-3">
                <div className="shop_sidebar_wrapper">
                    <h3>Filtreleme</h3>
                    <div className="shop_sidebar_boxed">
                        <h4>Ürün Kategorileri</h4>
                        <form>
                            <label className="custom_boxed" onClick={() => setCurrentCategory("all")}>Tümü
                                <input type="radio" name="radio" defaultChecked />
                                <span className="checkmark"></span>
                            </label>
                            {
                                props.categories?.map(category => 
                                    <label className="custom_boxed" onClick={() => setCurrentCategory(category)}>{category}
                                        <input type="radio" name="radio" />
                                        <span className="checkmark"></span>
                                    </label>
                                )
                            }
                        </form>
                    </div>
                    <div className="shop_sidebar_boxed">
                        <h4>Renk</h4>
                        <div className="product-variable-color">
                            <label htmlFor="modal-product-color-all">
                                <input name="modal-product-color" id="modal-product-color-all" className="color-select"
                                    type="radio" onClick={() => setCurrentColor("all")} defaultChecked/>
                                <span className="product-color-rainbow"></span>
                            </label>
                            <label htmlFor="modal-product-color-red6">
                                <input name="modal-product-color" id="modal-product-color-red6" className="color-select"
                                    type="radio" onClick={() => setCurrentColor("Kırmızı")}/>
                                <span className="product-color-red"></span>
                            </label>
                            <label htmlFor="modal-product-color-green2">
                                <input name="modal-product-color" id="modal-product-color-green2"
                                    className="color-select" type="radio"  onClick={() => setCurrentColor("Yeşil")}/>
                                <span className="product-color-green"></span>
                            </label>
                            <label htmlFor="modal-product-color-blue4">
                                <input name="modal-product-color" id="modal-product-color-blue4" className="color-select"
                                    type="radio" onClick={() => setCurrentColor("Mavi")}/>
                                <span className="product-color-blue"></span>
                            </label>
                            <label htmlFor="modal-product-color-black4">
                                <input name="modal-product-color" id="modal-product-color-black4" className="color-select"
                                    type="radio" onClick={() => setCurrentColor("Siyah")}/>
                                <span className="product-color-black"></span>
                            </label>
                            <label htmlFor="modal-product-color-brown4">
                                <input name="modal-product-color" id="modal-product-color-brown4" className="color-select"
                                    type="radio" onClick={() => setCurrentColor("Kahverengi")}/>
                                <span className="product-color-brown"></span>
                            </label>
                            <label htmlFor="modal-product-color-yellow4">
                                <input name="modal-product-color" id="modal-product-color-yellow4" className="color-select"
                                    type="radio" onClick={() => setCurrentColor("Sarı")}/>
                                <span className="product-color-yellow"></span>
                            </label>
                            <label htmlFor="modal-product-color-orange4">
                                <input name="modal-product-color" id="modal-product-color-orange" className="color-select"
                                    type="radio" onClick={() => setCurrentColor("Turuncu")}/>
                                <span className="product-color-orange"></span>
                            </label>
                        </div>
                    </div>
                    <div className="shop_sidebar_boxed">
                        <h4>Fiyat</h4>
                        <div className="price_filter">
                            <label>Min fiyat:</label>
                            <input type="text" defaultValue={minPrice} className="form-control-range" id="formControlRange" 
                            onChange={(e) => setMinPrice(parseInt(e.target.value ?? 0))}
                            />
                            <label>Max fiyat:</label>
                            <input type="text" defaultValue={maxPrice} className="form-control-range" id="formControlRange" 
                            onChange={(e) => setMaxPrice(parseInt(e.target.value ?? 5000))}
                            />
                        </div>
                    </div>
                    <div className="shop_sidebar_boxed">
                        <h4>Marka</h4>
                        <form>
                            <label className="custom_boxed" onClick={() => setCurrentBrand("all")}>Tümü
                                <input type="radio" name="radio" defaultChecked/>
                                <span className="checkmark"></span>
                            </label>
                            {props.brands?.map(brand =>
                                <label className="custom_boxed" onClick={() => setCurrentBrand(brand)}>{brand}
                                    <input type="radio" name="radio" />
                                    <span className="checkmark"></span>
                                </label>
                            )}
                            <div className="clear_button">
                                <button className="theme-btn-one btn_sm btn-black-overlay" type="button" onClick={() => clearFilters() }>Filtreyi Temizle</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </>
    )
}

export default SideBar
