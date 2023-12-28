import React from 'react'
import { Link } from 'react-router-dom'
import avater from '../../../assets/img/common/avater.png'
import { useSelector, useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom"
import Swal from 'sweetalert2';
import userManager from '../../../utils/userManager';
import { userIsLoggedIn } from '../../../app/slices/user';

const TopHeader = () => {
    let dispatch = useDispatch();
    const history = useNavigate()   //useNavigate hook'u, programmatic yönlendirmeleri gerçekleştirmek için kullanılır.

    let loggedIn = useSelector(userIsLoggedIn);
    let user = useSelector((state) => state.user.user);

    const login = () => {
        // Kullanıcıyı giriş yapma sayfasına yönlendiren bir fonksiyondur. 
        // Identity Server ile yapılandırılmış bir kimlik sağlayıcıya yönlendirme yapar.
        const customState = { path: window.location };
        userManager.signinRedirect({ state: customState });
    }

    const cikisYap = () => {
        // Kullanıcıyı çıkış yapmaya yönlendiren ve Redux üzerinden oturumu kapatma işlemi gerçekleştiren bir fonksiyondur.
        console.log("logouta tiklandi");
        dispatch({ type: "user/logout" })
        history("/");
    }
    return (
        <>
            <section id="top_header">
                <div className="container">
                    <div className="row">
                        <div className="col-lg-6 col-md-6 col-sm-12 col-12">
                            <div className="top_header_left">
                                <p>Özel koleksiyonlar için...<Link to="/shop/shop-left-sidebar">Daha fazlası...</Link></p>
                            </div>
                        </div>
                        <div className="col-lg-6 col-md-6 col-sm-12 col-12">
                            <div className="top_header_right">
                                {
                                    // Sol kısım, özel koleksiyonlar için bir bilgi içerir ve belirli bir ürün kategorisine yönlendiren bir bağlantı içerir.
                                    !loggedIn ?
                                        <ul className="right_list_fix">

                                            <li onClick={() => login()}><Link to="#"><i className="fa fa-lock"></i>
                                                Giriş Yap</Link></li>
                                            <li><Link to="/register"><i className="fa fa-lock"></i>
                                                Kayıt Ol</Link></li>
                                        </ul>

                                        :
                                        // Sağ kısım, kullanıcı oturum durumuna göre değişen bir menü içerir. 
                                        // Kullanıcı oturumda değilse giriş ve kayıt ol bağlantıları görüntülenir. 
                                        // Oturum açılmışsa, kullanıcının adı, profil resmi ve bir alt menü içeren bir menü görüntülenir. 
                                        // Bu alt menü, kullanıcının paneline, siparişlerine ve çıkış yapma seçeneğine yönlendiren bağlantıları içerir.
                                        <ul className="right_list_fix">
                                            <li><Link to="/order-tracking"><i className="fa fa-truck">
                                            </i> Siparişinizi Takip Edin!</Link></li>
                                            <li className="after_login"><img src={avater} alt="avater" />
                                                {user.profile.name} <i className="fa fa-angle-down"></i>
                                                <ul className="custom_dropdown">
                                                    <li><Link to="/my-account"><i className="fa fa-tachometer">
                                                    </i> Panel</Link></li>
                                                    <li><Link to="/my-account/customer-order">
                                                        <i className="fa fa-cubes"></i> Siparişlerim</Link></li>
                                                    <li><Link to="#!" onClick={() => { cikisYap() }} >
                                                        <i className="fa fa-sign-out"></i> Çıkış Yap</Link></li>
                                                </ul>
                                            </li>
                                        </ul>
                                }
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    )
}

export default TopHeader