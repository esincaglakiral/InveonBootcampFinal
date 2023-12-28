import React from "react";
import { Link } from 'react-router-dom'
import { useDispatch, useSelector } from "react-redux";
import img from '../../assets/img/common/empty-cart.png'
// Bu bileşen, kullanıcının favori ürünlerini görüntüleyebileceği bir sayfa oluşturur. Eğer favori ürünler varsa, 
// bunları tablo şeklinde gösterir. Eğer favori ürün yoksa, kullanıcıyı alışverişe devam etmeye yönlendiren bir boş 
// sayfa gösterir.

const WishArea = () => {
    let dispatch = useDispatch();
    let favorilerdekiUrunler = useSelector((state) => state.favorites.products);
    // Remove from Cart
    const rmProduct = (id) => {
        dispatch({ type: "products/removeToFav", payload: { id } });
    }
    // Clear
    const clearFav = () => {
        dispatch({ type: "products/clearFav" });
    }
    // Redux İşlemleri: Bileşen, favori ürünleri kaldırmak (rmProduct) ve favorileri temizlemek (clearFav) 
    // için Redux eylemlerini kullanır.


    return (
        <>
            {favorilerdekiUrunler.length
                ?
                <section id="cart_area_one" className="ptb-100">
                    <div className="container">
                        <div className="row">
                            <div className="col-lg-12 col-md-12 col-sm-12 col-12">
                                <div className="table_desc">
                                    <div className="table_page table-responsive">
                                        <table>
                                            <thead>
                                                <tr>
                                                    <th className="product_remove">Kaldır</th>
                                                    <th className="product_thumb">Resim</th>
                                                    <th className="product_name">Ürün</th>
                                                    <th className="product-price">Fiyat</th>

                                                </tr>
                                            </thead>
                                            <tbody>
                                                {favorilerdekiUrunler.map((data, index) => (
                                                    <tr key={index}>
                                                        <td className="product_remove">
                                                            <i className="fa fa-trash text-danger" onClick={() => rmProduct(data.id)} style={{ 'cursor': 'pointer' }}></i>
                                                        </td>
                                                        <td className="product_thumb">
                                                            <Link to={`/product-details-one/${data.id}`}>
                                                                <img src={data.img} alt="img" />
                                                            </Link>
                                                        </td>
                                                        <td className="product_name">
                                                            <Link to={`/product-details-one/${data.id}`}>
                                                                {data.title}
                                                            </Link>
                                                        </td>
                                                        <td className="product-price">{data.price} TL</td>

                                                    </tr>
                                                ))

                                                }
                                            </tbody>
                                        </table>
                                    </div>
                                    <div className="cart_submit">
                                        {favorilerdekiUrunler.length
                                            ? <button className="theme-btn-one btn-black-overlay btn_sm" type="button" onClick={() => clearFav()}>Favorileri Temizle</button>
                                            : null
                                        }

                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </section>
                : <section id="empty_cart_area" className="ptb-100">
                    <div className="container">
                        <div className="row">
                            <div className="col-lg-6 offset-lg-3 col-md-6 offset-md-3 col-sm-12 col-12">
                                <div className="empaty_cart_area">
                                    <img src={img} alt="img" />
                                    <h2>Favoriniz YOK</h2>
                                    <Link to="/shop/shop-left-sidebar" className="btn btn-black-overlay btn_sm">Alışverişe Devam</Link>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            }
        </>
    )
}

export default WishArea