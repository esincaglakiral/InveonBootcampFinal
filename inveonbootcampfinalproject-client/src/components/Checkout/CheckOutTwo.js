import React from 'react'
import TopLogin from './TopLogin'
import YourOrder from './YourOrder'
import { useRef, useEffect, useState } from 'react'
import HttpService from '../../services/HttpService'
import { selectTotalCartCost } from '../../app/slices/cart'
import {useDispatch, useSelector} from "react-redux"
import { useNavigate } from "react-router-dom";

const CheckOutTwo = () => {
    const orderTotal = useSelector(selectTotalCartCost)  //orderTotal: Redux store'dan alışveriş sepetinin toplam maliyetini depolar.

    const purchaseButton = useRef()  //purchaseButton ve informationForm: ref kullanılarak belirli DOM elementlerine erişimi sağlar.
    const informationForm = useRef()
    const [paymentSuccess, setPaymentSuccess] = useState(null)  //paymentSuccess: Ödeme başarılı olduğunda veya başarısız olduğunda durumu depolar.
    const navigate = useNavigate();
    const dispatch = useDispatch()
    const createPayment = async () => {

// Kullanıcının girdiği bilgileri kullanarak ödeme oluşturan bir fonksiyon.
// Formdaki her bir öğeyi döngü ile alır ve bir nesneye ekler.
// HttpService.createPayment kullanılarak ödeme oluşturulur.
// Başarılıysa Redux store'daki alışveriş sepeti temizlenir 
// (cart/clearCart) ve kullanıcı "order-complete" sayfasına yönlendirilir.

        console.debug("CreatePayment clicked.")
        const formElements = informationForm.current.elements;
        const paymentInformation = {};
        for (let i = 0; i < formElements.length; i++) {
            const element = formElements[i];
            if (element.name) {
                paymentInformation[element.name] = element.value;
            }
        }
        paymentInformation.OrderTotal = orderTotal;
        console.log('paymentInformation: ', paymentInformation);
        const result = await HttpService.createPayment(paymentInformation);
        if (result.isSuccess) {
            dispatch({type: "cart/clearCart"})
            navigate("/order-complete")
        }
        setPaymentSuccess(result);
    }

    return (
        <>
            <section id="checkout_two" className="ptb-100">
                <div className="container">
                    <div className="row">
                        <div className="col-lg-12">
                            <div className="checkout_area_two">
                            {/* {
                                (paymentSuccess !== null && !paymentSuccess.isSuccess) &&
                            } */}
                            <div className='row'></div>
                                <div className="row">
                                    <div className="col-lg-6 col-md-6">
                                        <div className="checkout_form_area">
                                            <h3>Fatura Adresi</h3>
                                            <form action="#" ref={informationForm}>
                                                <div className="row">
                                                    <div className="col-lg-6">
                                                        <div className="default-form-box">
                                                            <label >Kart Numarası<span className="text-danger">*</span></label>
                                                            <input type="text" name="cardNumber" className="form-control" />
                                                        </div>
                                                    </div>
                                                    <div className="col-lg-6">
                                                        <div className="default-form-box">
                                                            <label >CVV<span className="text-danger">*</span></label>
                                                            <input type="text" name="CVV" className="form-control" />
                                                        </div>
                                                    </div>
                                                    <div className="col-lg-6">
                                                        <div className="default-form-box">
                                                            <label>Son Kullanma Ay<span className="text-danger">*</span></label>
                                                            <input type="text" name="ExpiryMonth" className="form-control" />
                                                        </div>
                                                    </div>
                                                    <div className="col-lg-6">
                                                        <div className="default-form-box">
                                                            <label>Son Kullanma Yıl<span className="text-danger">*</span></label>
                                                            <input type="text" name="ExpiryYear" className="form-control" />
                                                        </div>
                                                    </div>

                                                    <div className="col-lg-6">
                                                        <div className="default-form-box">
                                                            <label >Adınız<span className="text-danger">*</span></label>
                                                            <input type="text" name="firstName" className="form-control" />
                                                        </div>
                                                    </div>
                                                    <div className="col-lg-6">
                                                        <div className="default-form-box">
                                                            <label>Soyadınız <span className="text-danger">*</span></label>
                                                            <input type="text" name="lastName"className="form-control" />
                                                        </div>
                                                    </div>
                                                    <div className="col-12">
                                                        <div className="default-form-box">
                                                            <label>Şirket Adı<span className="text-danger">*</span></label>
                                                            <input type="text" name="companyName" className="form-control" />
                                                        </div>
                                                    </div>
                                                    <div className="col-12">
                                                        <div className="default-form-box">
                                                            <label htmlFor="country">Ülke<span className="text-danger">*</span></label>
                                                            <select className="country_option nice-select wide form-control"
                                                                name="country" id="country">
                                                                <option defaultValue="1">Türkiye</option>
                                                                <option defaultValue="2">Bangladesh</option>
                                                                <option defaultValue="3">Algeria</option>
                                                                <option defaultValue="4">Afghanistan</option>
                                                                <option defaultValue="5">Ghana</option>
                                                                <option defaultValue="6">Albania</option>
                                                                <option defaultValue="7">Bahrain</option>
                                                                <option defaultValue="8">Colombia</option>
                                                                <option defaultValue="9">Dominican Republic</option>
                                                            </select>
                                                        </div>
                                                    </div>
                                                    <div className="col-12">
                                                        <div className="default-form-box">
                                                            <label>Cadde<span className="text-danger">*</span></label>
                                                            <input placeholder="Cadde Adı" type="text" name="caddeName"
                                                                className="form-control" />
                                                        </div>
                                                    </div>
                                                    <div className="col-12">
                                                        <div className="default-form-box">
                                                            <input placeholder="Numara"
                                                                type="text" className="form-control" name="doorNumber"/>
                                                        </div>
                                                    </div>
                                                    <div className="col-12">
                                                        <div className="default-form-box">
                                                            <label>Şehir<span className="text-danger">*</span></label>
                                                            <input type="text" className="form-control" name="cityName"/>
                                                        </div>
                                                    </div>
                                                    <div className="col-lg-6">
                                                        <div className="default-form-box">
                                                            <label>Telefon <span className="text-danger">*</span></label>
                                                            <input type="text" className="form-control" name="phoneNumber"/>
                                                        </div>
                                                    </div>
                                                    <div className="col-lg-6">
                                                        <div className="default-form-box">
                                                            <label> Email Adresiniz<span className="text-danger">*</span></label>
                                                            <input type="text" className="form-control" name="emailAddress"/>
                                                        </div>
                                                    </div>

                                                    <div className="col-12">
                                                        <div className="order-notes">
                                                            <label htmlFor="order_note">Sipariş Notunuz<span className="text-danger">*</span></label>
                                                            <textarea id="order_note"
                                                                placeholder=""
                                                                className="form-control" rows="5" name="orderNote"></textarea>
                                                        </div>
                                                    </div>
                                                </div>
                                            </form>
                                        </div>
                                    </div>
                                    <YourOrder paymentFunction={createPayment}/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    )
}

export default CheckOutTwo