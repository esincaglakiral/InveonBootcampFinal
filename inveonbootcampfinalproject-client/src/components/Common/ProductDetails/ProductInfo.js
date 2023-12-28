import React, { useEffect, useState } from 'react'
import {fetchReviews, postReviewAsync} from "../../../app/slices/reviews" 
import { useSelector, useDispatch } from 'react-redux'; 
//Redux store'a erişim için useSelector ve useDispatch kullanılır.
//useEffect ve useState React kütüphanesinden alınır
//fetchReviews ve postReviewAsync fonksiyonları, Redux action'larıdır.



const ProductInfo = ({productId}) => {
    // Bu bileşen, ürün detayları, ek bilgiler ve müşteri yorumlarını içeren bir sayfa yapısını temsil eder. 
    // Müşteriler, ürün hakkında bilgi alabilir, ek bilgileri görebilir ve diğer kullanıcıların yorumlarını 
    // okuyabilir veya kendi yorumlarını ekleyebilir.


    const dispatch = useDispatch();
    const [rating, setRating] = useState(0);
    const [comment, setComment] = useState('');
    const { reviews, status, error } = useSelector((state) => state.reviews);
    const ReviewData = reviews ?? [];
    // rating, kullanıcının belirlediği puanı tutar.
    // comment, kullanıcının girdiği yorumu tutar.
    // reviews, status, ve error, Redux store'dan alınan yorum bilgilerini içerir.
    // productId, ürün bilgilerini çekmek için kullanılan parametre.

    const handleRatingChange = (event) => {  //handleRatingChange: Puan seçimini izleyen olay işleyici.
        setRating(parseInt(event.target.value, 10));
      };
    
      const handleCommentChange = (event) => {  //handleCommentChange: Yorum girişini izleyen olay işleyici.
        setComment(event.target.value);
      };
    
      const handleSubmit = (event) => {  //handleSubmit: Yorum gönderme işlemi için olay işleyici.
        event.preventDefault()
        dispatch(postReviewAsync({productId, rating, comment}))
        setRating(0);
        setComment('');
      };

    return (
        <>
            <div className="row">
                <div className="col-lg-12">
                    <div className="product_details_tabs">
                        <ul className="nav nav-tabs">
                            <li><a data-toggle="tab" href="#description" className="active">Açıklama</a></li>
                            <li><a data-toggle="tab" href="#additional">Ek Bilgiler</a></li>
                            <li><a data-toggle="tab" href="#review">Yorumlar</a></li>
                        </ul>
                        <div className="tab-content">
                            <div id="description" className="tab-pane fade in show active">
                                <div className="product_description">
                                    <p>Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem. Vestibulum ac
                                        diam sit amet quam vehicula elementum sed sit amet dui.
                                        Sed porttitor lectus nibh. Vivamus magna justo, lacinia eget consectetur sed,
                                        convallis at tellus. Sed porttitor lectus nibh.
                                        Donec sollicitudin molestie malesuada. Vivamus magna justo,
                                        lacinia eget consectetur sed, convallis at tellus. Curabitur arcu erat, accumsan
                                        id imperdiet et, porttitor at sem.</p>
                                    <ul>
                                        <li>Vivamus magna justo, lacinia eget consectetur sed</li>
                                        <li>Curabitur aliquet quam id dui posuere blandit</li>
                                        <li>Mauris blandit aliquet elit, eget tincidunt nibh pulvinar </li>
                                    </ul>
                                    <p>Donec sollicitudin molestie malesuada. Cras ultricies ligula sed magna dictum
                                        porta.
                                        Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a.
                                        Nulla porttitor accumsan tincidunt. Cras ultricies ligula sed magna dictum
                                        porta. Curabitur arcu erat, accumsan id imperdiet et,
                                        Pellentesque in ipsum id orci porta dapibus. Lorem ipsum dolor sit amet,
                                        consectetur adipiscing elit.
                                        porttitor at sem. Quisque velit nisi, pretium ut lacinia in, elementum id enim.
                                    </p>
                                </div>
                            </div>
                            <div id="additional" className="tab-pane fade">
                                <div className="product_additional">
                                    <ul>
                                        <li>Weight: <span>400 g</span></li>
                                        <li>Dimensions: <span>10 x 10 x 15 cm</span></li>
                                        <li>Materials: <span> 60% cotton, 40% polyester</span></li>
                                        <li>Other Info: <span> American heirloom jean shorts pug seitan
                                            letterpress</span></li>
                                    </ul>
                                </div>
                            </div>
                            <div id="review" className="tab-pane fade">
                            <div className="review-form">
                                <h2>Ürünü Değerlendirin</h2>
                                <form onSubmit={handleSubmit}>
                                    <div className='d-flex flex-column mt-3'>
                                    <label htmlFor="rating">Puan:</label>
                                    <select id="rating" value={rating} onChange={handleRatingChange}>
                                        <option value={0}>Puan Seçin</option>
                                        <option value={1}>1 - Çok kötü</option>
                                        <option value={2}>2 - Kötü</option>
                                        <option value={3}>3 - İyi</option>
                                        <option value={4}>4 - Çok İyi</option>
                                        <option value={5}>5 - Mükemmel</option>
                                    </select>
                                    </div>
                                    <div className='d-flex flex-column mt-3'>
                                    <label htmlFor="comment">Yorum:</label>
                                    <textarea
                                        id="comment"
                                        value={comment}
                                        onChange={handleCommentChange}
                                        rows={4}
                                    ></textarea>
                                    </div>
                                    <button type="submit" className='mt-3'>Yorumu Gönder</button>
                                </form>
                            </div>  
                                <div className="product_reviews">
                                    {!!ReviewData.length &&
                                        <ul>
                                            <li><h3>Diğer müşterilerin yorumları:</h3></li>
                                            {ReviewData.map((data, index) => (
                                                <li className="media" key={index}>
                                                    <div className="media-img">
                                                        {/* <img src={data.img} alt="img" /> */}
                                                    </div>
                                                    <div className="media-body">
                                                        <div className="media-header">
                                                            <div className="media-name">
                                                                <h4>{data.userName || "Bilinmeyen Kullanıcı"}</h4>
                                                                {/* <h4>{data.userId}</h4> */}
                                                                <p>{new Date(data.timestamp).toLocaleDateString()}</p>
                                                            </div>
                                                            <div className="product_review_strat d-flex">
                                                                <div className="mr-2">{data.rating}</div>
                                                                <div><i className="fa fa-star"></i></div>
                                                            </div>
                                                        </div>
                                                        <div className="media-pragraph">
                                                            <div>{data.comment}</div>
                                                        </div>
                                                    </div>
                                                </li>
                                            ))}
                                        </ul>
                                    }
                                    {
                                        !!!ReviewData.length && 
                                        <div> There are no reviews for this product, yet.</div>
                                    }
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default ProductInfo