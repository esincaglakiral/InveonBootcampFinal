import React from 'react'
import { Link } from 'react-router-dom'
import img1 from '../../assets/img/common/avatar.png'
const AccountDetails = () => {

    //AccountDetails bileşeni, kullanıcının hesap detaylarını görüntülediği bir sayfa görünümünü temsil eder
    return (
        <>
            <div className="myaccount-content">
                <div className="save_button mt-3 d-flex align-items-center justify-content-between">
                    <h4 className="title">Hesap Detay</h4>
                    <Link to="/account-edit" className="theme-btn-one bg-black btn_sm">Güncelle</Link>
                </div>
                <div className="login_form_container">
                    <div className="account_details_form">
                        <form action="#">
                            <div className="img_profiles">
                                <img src={img1} alt="img" />
                            </div>
                            <div className="input-radio">
                                <span className="custom-radio">
                                    <input type="radio" defaultValue="1" name="mr" checked readOnly /> Bay.</span>
                            </div>
                            <div className="default-form-box mb-20">
                                <label>İbrahim</label>
                                <input type="text" name="first-name" className="form-control" defaultValue=""
                                    readOnly />
                            </div>
                            <div className="default-form-box mb-20">
                                <label>Gökyar</label>
                                <input type="text" name="last-name" className="form-control" defaultValue=""
                                    readOnly />
                            </div>
                            <div className="default-form-box mb-20">
                                <label>Email</label>
                                <input type="text" name="email-name" defaultValue="ibr@ibr.com"
                                    className="form-control" readOnly />
                            </div>
                            <div className="default-form-box mb-20">
                                <label>Password</label>
                                <input type="password" name="user-password" defaultValue="123456"
                                    className="form-control" readOnly />
                            </div>
                            <div className="default-form-box mb-20">
                                <label>Doğum Tarihi</label>
                                <input type="date" name="birthday" defaultValue="2017-06-01"
                                    className="form-control" readOnly />
                            </div>
                            <span className="example">
                                ( 01/05/1998)
                            </span>
                            <br />
                            <label className="checkbox-default" htmlFor="offer">
                                <input type="checkbox" id="offer" />
                                <span className="ml-2">Ortaklarımızdan teklif alın</span>
                            </label>
                            <br />
                            <label className="checkbox-default checkbox-default-more-text" htmlFor="newsletter">
                                <input type="checkbox" id="newsletter" />
                                <span className="ml-2">Bültenimize kaydolun</span>
                                <p className="mt-2">Herhangi bir zamanda abonelikten çıkabilirsiniz!</p>
                            </label>
                        </form>
                    </div>
                </div>
            </div>
        </>
    )
}

export default AccountDetails
