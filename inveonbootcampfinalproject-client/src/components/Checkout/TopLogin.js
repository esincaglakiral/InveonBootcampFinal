import React from 'react'
import { useSelector, useDispatch } from "react-redux";
import Swal from 'sweetalert2';

const TopLogin = () => {
    let dispatch = useDispatch();
// useDispatch ve useSelector hook'ları kullanılarak Redux store'dan 
// dispatch fonksiyonu ve kullanıcı durumu (status) ile kullanıcı bilgileri (user) alınır.
    let status = useSelector((state) => state.user.status);
    let user = useSelector((state) => state.user.user);

    // Login
    const login = () => {
        if(status){
            Swal.fire({
                icon: 'question',
                title: ''+user.name,
                html:'Zaten giriş yaptınız... <br />'
            })
        }else{
            dispatch({ type: "user/login" })
            let name = user.name || 'Customer'
            console.log(typeof(user.name));
            Swal.fire({
                icon: 'success',
                title: 'Giriş başarılı',
                text: 'Hoşgeldin '+ name
            })
        }

    }
    return (
        <>
            <div className="col-12">
                <div className="user-actions accordion">
                    <h3>
                        <i className="fa fa-file mr-2"></i>
                       
                        <a className="Returning  ml-2" href="#!" data-toggle="collapse"
                         data-target="#checkout_login"
                            aria-expanded="true">Giriş yapmak için tıklayınız.</a>
                    </h3>
                    <div id="checkout_login" className="collapse" data-parent="#checkout_login">
                        <div className="checkout_info">
                            <p>Bizden daha önce alışveriş yaptıysanız, lütfen aşağıdaki kutulara bilgilerinizi giriniz.</p>
                            <form onSubmit={(e)=>{e.preventDefault();login()}}>
                                <div className="form_group default-form-box">
                                    <label>Kullanıcı Adınız veya Email Adresiniz <span className="text-danger">*</span></label>
                                    <input type="text" className="form-control" />
                                </div>
                                <div className="form_group default-form-box">
                                    <label>Şifre <span className="text-danger">*</span></label>
                                    <input type="password" className="form-control" />
                                </div>
                                <div className="form_group group_3 default-form-box">
                                    <button className="theme-btn-one btn-black-overlay btn_md"
                                        type="submit">Login</button>
                                    <label className="checkbox-default">
                                        <input type="checkbox" />
                                        <span>Beni Hatırla</span>
                                    </label>
                                </div>
                                <a href="#!">Şifrenimi Unuttum?</a>
                            </form>
                        </div>
                    </div>
                </div>
                <div className="user-actions accordion">
                    <h3>
                        <i className="fa fa-file mr-2"></i>
                        Kupon Kodunuzu Giriniz
                        <a className="Returning ml-2" href="#!" data-toggle="collapse" data-target="#checkout_coupon"
                            aria-expanded="true">Kupon Kodu</a>
                    </h3>
                    <div id="checkout_coupon" className="collapse checkout_coupon" data-parent="#checkout_coupon">
                        <div className="checkout_info">
                            <form onSubmit={(e) => { e.preventDefault(); Swal.fire('Error!!', 'Geçersiz Kupon Kodu', 'error') }}>
                                <input className="mb-2" placeholder="Kupon Kodu" type="text" required />
                                <button type="submit" className="theme-btn-one btn-black-overlay btn_sm">Onayla</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default TopLogin