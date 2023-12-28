import React, {useState} from "react";
import { useDispatch } from "react-redux";
import {Link} from "react-router-dom";
import {AiOutlineHeart} from 'react-icons/ai';
// Her bir ürünü temsil edecek
// Bir ürünün kartını temsil eder ve kullanıcıya ürünü detaylarına gitme, 
// favorilere ekleme ve sepete ekleme gibi işlemleri gerçekleştirme imkanı sunar.
const ProductCard = ({product}) => {
        const [photoUrl, setPhotoUrl] = useState(getRandomImageUrl())
        let dispatch = useDispatch();

        const sepeteEkle = async(id) => {
            dispatch({type :"products/AddToCart",payload : {id}})
        }
        
        const favorilereEkle = async(id) => {
            dispatch({type :"products/addToFavorites",payload : {id}})
        }

    if (!product) {
        return <></>
    }
    function getRandomImageUrl() {
        const x = Math.floor(Math.random() * 20) + 1;
        return `/pictures/${x}.jpg`;
      }

    return(
        <>
         <div className="product_wrappers_one">
            <div className="thumb">
                 <Link to={`/product-details-two/${product.productId}`} className="image">
                    <img src={photoUrl} alt={`${product.name} picture`}></img>
                    <img className="hover-image" src={photoUrl} alt={`${product.name} picture`} />
                 </Link>
                   <div className="actions">
                     <a href="#!" className="action wishlist" title="Favorilere Ekle"
                      onClick={() => favorilereEkle(product.productId)} ><AiOutlineHeart />

                     </a>
                 </div>
                 <button type="button" className="add-to-cart offcanvas-toggle" 
                    onClick={() => sepeteEkle(product.productId)}> Sepete Ekle </button>
             </div>
             <div className="content">
                <h5 className="title">
                    <Link to={`/product-details-two/${product.productId}`}>{product.name}</Link>
                    <Link to={`/product-details-two/${product.productId}`}>{product.description}</Link>
                </h5>
                <span className="price">
                    <span className="new">{product.price} TL</span>
                </span>
             </div>
               
            </div>
        </>
    )
}

export default ProductCard