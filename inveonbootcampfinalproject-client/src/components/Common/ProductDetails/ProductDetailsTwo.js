import ProductInfo from './ProductInfo'
import RelatedProduct from './RelatedProduct'
import { Link } from 'react-router-dom'
import { useState, useEffect } from 'react'
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import Slider from "react-slick";
import { useSelector, useDispatch } from "react-redux";
import { useParams } from 'react-router-dom';
import { RatingStar } from "rating-star";
import { fetchProductById, selectProductById }  from "../../../app/slices/product"
import { addToCart } from '../../../app/slices/cart';
import Swal from "sweetalert2";
import { addToFavorites, removeFromFavorites, selectAllFavorites } from '../../../app/slices/favorites';
import {fetchReviews} from "../../../app/slices/reviews" 

const ProductDetailsTwo = () => {

    // bir ürünün detaylarını ve kullanıcı tarafından yapılabilecek çeşitli işlemleri yöneten bir bileşeni temsil eder. 
    // Bu işlemler arasında ürünü sepete eklemek, favorilere eklemek, ürün detaylarını göstermek ve benzer ürünleri 
    // göstermek gibi işlemler bulunur.
   
    let dispatch = useDispatch();

    let { id } = useParams();
    id = parseInt(id);

    const product = useSelector(state => state.products.singleProduct)
    const productStock = useSelector(state => state.products.singleProductStock)
    const productStatus = useSelector(state => state.products.singleProductStatus)
    const favorites = useSelector(selectAllFavorites)
    const user = useSelector(state => state.user.user)
    const [photoUrl, setPhotoUrl] = useState(getRandomImageUrl())
    console.log('photoUrl: ', photoUrl);
    const { reviews, status, error } = useSelector((state) => state.reviews);
    const ReviewData = reviews ?? [];

    useEffect(() => {
        dispatch(fetchReviews(id));
    }, [dispatch]);

    useEffect(() => {
        if ((productStatus === 'idle' && !product) || (product !== null && product.id !== id && productStatus === 'succeeded')) {
            console.log("fetching product")
            dispatch(fetchProductById({id: id, access_token: user.access_token}))
        }
    }, [dispatch])

    // Quenty Inc Dec
    const [size, setSize] = useState(null)
    const [count, setCount] = useState(1)

    const incNum = () => {
        if (count + 1 <= productStock.find(s => s.size === size)?.stockQuantity) { // TODO replace by stock count
            setCount(count + 1)
        }
        else {
            alert("Not in stock!")
        }
    }
    const decNum = () => {
        if (count > 1)
            setCount(count - 1)
    }

    function getRandomImageUrl() {
        const x = Math.floor(Math.random() * 20) + 1;
        return `/pictures/${x}.jpg`;
      }
    // Add to cart
    const addProductToCart = async (id, size, count) => {
        console.log('size: ', size);
        if (!size) {
            Swal.fire(
                {
                    title: 'Ürün Bedeni',
                    text: "Lütfen beden seçin!",
                    icon: 'error',
                    showConfirmButton: true,
                    timer: 2000
                }
            )
            return;
        }

        dispatch(addToCart(id, size, count));
    }

    // Add to Favorite
    const addToFav = async (productId) => {
        if (!!!favorites.find(fav => fav.productId === id)) {
            dispatch(addToFavorites(productId))
        }
        else {
            dispatch(removeFromFavorites(productId))
        }
    }

    let settings = {
        arrows: true,
        dots: true,
        infinite: true,
        speed: 500,
        fade: true,
        autoplay: true,
        slidesToShow: 1,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                }
            }
        ]
    };

    if (!product) {
        return <></>
    }

    return (
        <>{product
            ?
            <section id="product_single_two" className="ptb-100">
                <div className="container">
                    <div className="row area_boxed">
                        <div className="col-lg-4">
                            <div className="product_single_two_img slider-for">
                                <Slider {...settings}>
                                    <div className="product_img_two_slider">
                                        <img src={photoUrl} alt="img" />
                                    </div>
                                    <div className="product_img_two_slider">
                                        <img src={photoUrl} alt="img" />
                                    </div>
                                    {/* {
                                        product.color.map(item => (
                                            <div className="product_img_two_slider">
                                                <img src={product.imageUrls.split(";")[0]} alt="img" />
                                            </div>
                                        ))
                                    } */}
                                </Slider>
                            </div>

                        </div>
                        <div className="col-lg-8">
                            <div className="product_details_right_one">
                                <div className="modal_product_content_one">
                                    <h3>{product.name}</h3>
                                    <div className="reviews_rating">
                                        <RatingStar maxScore={5} 
                                        rating={reviews.reduce((prev, current) => prev + current.rating, 0) / reviews.length} 
                                        id="rating-star-common-2" />
                                        <span>({reviews.length} Müşteri Yorumları)</span>
                                    </div>
                                    <h4>{product.price} {product.currencyType} <del>{parseInt(product.price) + 17}.00 TL</del> </h4>
                                    <p>{product.description}</p>
                                    <div className="customs_selects">
                                        
                                        <select 
                                            name="product" 
                                            className="customs_sel_box"
                                            onChange={(e) => setSize(e.target.value)}
                                        >
                                            <option value="">Beden</option>
                                            {
                                                productStock.map(stock => {
                                                    return (
                                                        <option value={stock.size}>{stock.size} ({stock.stockQuantity})</option>
                                                    )
                                                })
                                            }
                                        </select>
                                    </div>
                                    <form id="product_count_form_two">
                                        <div className="product_count_one">
                                            <div className="plus-minus-input">
                                                <div className="input-group-button">
                                                    <button type="button" className="button" onClick={decNum}>
                                                        <i className="fa fa-minus"></i>
                                                    </button>
                                                </div>
                                                <input className="form-control" type="number" value={count} readOnly />
                                                <div className="input-group-button">
                                                    <button type="button" className="button" onClick={incNum}>
                                                        <i className="fa fa-plus"></i>
                                                    </button>
                                                </div>
                                            </div>
                                        </div>
                                    </form>
                                    <div className="links_Product_areas">
                                        <ul>
                                            <li>
                                                <a href="#!" className="action wishlist" title="Wishlist" onClick={() => addToFav(product.productId)}><i
                                                    className="fa fa-heart"></i>{!!favorites.find(fav => fav.productId === id) ? "Favorilerden Sil" : "Favorilere Ekle"}</a>
                                            </li>
                                         
                                        </ul>
                                        <a href="#!" className="theme-btn-one btn-black-overlay btn_sm"
                                         onClick={() => addProductToCart(product.productId, size, count)}>Sepete Ekle</a>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                    <ProductInfo productId={id}/>
                </div>
            </section>
            :
            <div className="container ptb-100">
                <div className="row">
                    <div className="col-lg-6 offset-lg-3 col-md-6 offset-md-3 col-sm-12 col-12">
                        <div className="empaty_cart_area">
                            <img src={"cannot_find.jpeg"} alt="img" />
                            <h2>Ürün Bulunamadı</h2>
                            <Link to="/shop/shop-left-sidebar" className="btn btn-black-overlay btn_sm">Alışverişe Devam</Link>
                        </div>
                    </div>
                </div>
            </div>
        }
            <RelatedProduct />
        </>
    )
}

export default ProductDetailsTwo