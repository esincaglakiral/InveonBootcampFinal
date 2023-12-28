import React from 'react';
import { Link } from "react-router-dom";
import { useSelector, useDispatch }  from "react-redux";
import { selectAllCartItems, selectTotalCartCost } from '../../app/slices/cart';

const YourOrder = (props) => {
    //useSelector hook'u kullanılarak Redux store'dan alışveriş sepetindeki 
    //ürünler (cartProducts) ve toplam sipariş tutarı (cartTotal) alınır.
    const cartProducts = useSelector(selectAllCartItems)
    const cartTotal = useSelector(selectTotalCartCost)
    const shippingCost = 15.00;
    const totalSum = Number((cartTotal + shippingCost).toFixed(2))
    function getRandomImageUrl() {
        //tablodaki her ürün için rastgele bir ürün resmi almak için kullanılır.
        const x = Math.floor(Math.random() * 20) + 1;
        return `/pictures/${x}.jpg`;
      }

    return (
        <>
            <div className="col-lg-6 col-md-6">
                <h3>Siparişiniz</h3>
                <div className="order_table table-responsive">
                    <table className='table text-nowrap'>
                        <thead>
                            <tr>
                                <th>Adet</th>
                                <th>Ürün</th>
                                <th></th>
                                <th>Toplam</th>
                            </tr>
                        </thead>
                        <tbody>
                                {cartProducts.map(product => {
                                    return (
                                        <tr>
                                            <td style={{width: "30%"}}className='col-2' colSpan={1}>{product.quantity} 
                                                <img src={getRandomImageUrl()}></img>
                                            </td>
                                            <td style={{width: "40%"}}colSpan={2}>
                                                {product.name} ({product.size}) {
                                                    product.quantity > 1 && 
                                                    <div>({product.price} TL/adet)</div>
                                                }
                                            </td>
                                            <td style={{width: "30%"}} colSpan={2}>{product.quantity * product.price} TL</td>
                                        </tr>
                                    )
                                })}
                        </tbody>
                        <tfoot>
                            <tr>
                                <th></th>
                                <th></th>
                                <th>Alt Toplam</th>
                                <td>
                                {cartTotal} TL
                                </td>
                            </tr>
                            <tr>
                                <th></th>
                                <th></th>
                                <th>Kargo</th>
                                <td>{shippingCost} TL</td>
                            </tr>
                            <tr className="order_total">
                             <th></th>
                                <th></th>
                                <th>Sipariş Toplamı </th>
                                <td><strong>{totalSum} TL</strong></td>
                            </tr>
                        </tfoot>
                    </table>
                </div>
                <div className="payment_method">
                    <form>
                        <div className="accordion" id="accordionExample">
                            <div className="payment_area_wrappers">
                                <div className="heading_payment" id="headingOne">
                                    <div className="" data-target="#collapseOne" >
                                        <input type="radio" name="payment" id="html" value="HTML" defaultChecked />
                                        <label htmlFor="html">Banka/Kredi kartı</label>
                                    </div>
                                </div>
                                <div id="collapseOne"  aria-labelledby="headingOne" data-parent="#accordionExample">
                                    <div className="payment_body">
                                        <p>İyzico aracılığıyla banka veya kredi kartın ile öde!</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>

                    <div className="order_button pt-3">
                    {/* Buton tıklandığında, props.paymentFunction() fonksiyonu çalıştırılır. Bu fonksiyon genellikle ödeme işlemini tamamlar ve kullanıcıyı sipariş tamamlama sayfasına yönlendirir. */}
                        <button className="theme-btn-one btn-black-overlay btn_sm" onClick={() => props.paymentFunction()}>
                                Sipariş Ver</button>
                    </div>
                </div>
            </div>
        </>
    )
}

export default YourOrder