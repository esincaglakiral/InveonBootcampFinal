import React from 'react'
import { Link, useLocation } from 'react-router-dom'
import { useSelector, useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom"
import Swal from 'sweetalert2';

const Sidebar = () => {
    const location = useLocation()
    let dispatch = useDispatch();
    const history = useNavigate()
    let status = useSelector((state) => state.user.status);
    const logout = () => {  //Kullanıcı giriş yapmışsa, Çıkış Yap bağlantısı görünür.
        Swal.fire({
            icon: 'success',
            title: 'Çıkış Başarılı',
            text: 'Teşekürrler'
        })
        dispatch({ type: "user/logout" })
        history("/login");
    }
    return (
        // Kullanıcının hesap yönetimi için kullanabileceği bağlantıları içerir.
        // Siparişlerim, Adreslerim, Profilim gibi bağlantılar bulunur.
        <>
            <div className="col-sm-12 col-md-12 col-lg-3">
                <div className="dashboard_tab_button">
                    <ul role="tablist" className="nav flex-column dashboard-list">
                        <li> <Link to="/my-account/customer-order" className={location.pathname === '/my-account/customer-order'?'active':null}><i className="fa fa-cart-arrow-down"></i>Siparişlerim</Link></li>
                        <li><Link to="/my-account/customer-address" className={location.pathname === '/my-account/customer-address'?'active':null}><i className="fa fa-map-marker"></i>Addreslerim</Link></li>
                        <li><Link to="/my-account/customer-account-details" className={location.pathname === '/my-account/customer-account-details'?'active':null}><i className="fa fa-user"></i>Profilim</Link></li>
                        {
                            status?<li><Link to="/#!" onClick={(e)=>{e.preventDefault();logout()}}><i className="fa fa-sign-out"></i>Çıkış Yap</Link></li>:null
                        }
                    </ul>
                </div>
            </div>
        </>
    )
}

export default Sidebar
