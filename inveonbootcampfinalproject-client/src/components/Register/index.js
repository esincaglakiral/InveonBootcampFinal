import React, {useState} from 'react'
import { useSelector, useDispatch } from "react-redux";
import Swal from 'sweetalert2';
import { useNavigate } from "react-router-dom"
import httpClient from "../../services/HttpService"
import userManager from '../../utils/userManager';
const RegisterArea = () => {
    let dispatch = useDispatch();
    const history = useNavigate()
    const [user, setUser] = useState('')
    const [email, setEmail] = useState('')
    const [pass, setPass] = useState('')
    const [firstName, setFirstName] = useState('')
    const [lastName, setLastName] = useState('')

    const register = async () => {
        // Kullanıcının kayıt olma işlemini gerçekleştiren fonksiyondur. Bu fonksiyon, httpClient 
        // tarafından sağlanan register fonksiyonunu kullanır ve kayıt işlemi başarılı olduğunda kullanıcıyı bilgilendirir.
        const result = await httpClient.register(user, email, pass, firstName, lastName);
        if (result.status === 200) {
            // Başarılı kayıt durumunda kullanıcı bilgilendirilir.
            Swal.fire(
                {
                    title: 'Başarılı',
                    text: "Başarıyla kayıt oldunuz.",
                    icon: 'success',
                    showConfirmButton: false,
                    timer: 2000
                }
            )
               // Kullanıcı bilgileri alınıp, Redux store'a gönderilir.
            userManager.getUser()
            .then(async data => {
                if (data) {
                let d = JSON.stringify(data);
                let f = JSON.parse(d);
                dispatch({ type: "user/login", payload: { user: f, status: true} })
                }
            })
          // Anasayfaya yönlendirme yapılır.
            history("/")
        }
        else {
              // Hata durumunda kullanıcı bilgilendirilir.
            Swal.fire(
                {
                    title: ':(',
                    text: `Hata! ${"Lütfen farklı bir kullanıcı adı deneyin!"}`,
                    icon: 'error',
                    showConfirmButton: false,
                    timer: 2000
                }
            )
        }
    }
        
    return (
        <>
            <section id="login_area" className="ptb-100">
                <div className="container">
                    <div className="row">
                        <div className="col-lg-6 offset-lg-3 col-md-12 col-sm-12 col-12">
                            <div className="account_form">
                                <h3>Kayıt Ol</h3>
                                <form onSubmit={(e)=>{e.preventDefault();register()}}>
                                    <div className="default-form-box">
                                        <label>Kullanıcı Adı<span className="text-danger">*</span></label>
                                        <input type="text" className="form-control" value={user} onChange={e => setUser(e.currentTarget.value)} required/>
                                    </div>
                                    <div className="default-form-box">
                                        <label>İsim<span className="text-danger">*</span></label>
                                        <input type="text" className="form-control" value={firstName} onChange={e => setFirstName(e.currentTarget.value)} required/>
                                    </div>
                                    <div className="default-form-box">
                                        <label>Soyisim<span className="text-danger">*</span></label>
                                        <input type="text" className="form-control" value={lastName} onChange={e => setLastName(e.currentTarget.value)} required/>
                                    </div>
                                    <div className="default-form-box">
                                        <label>Email<span className="text-danger">*</span></label>
                                        <input type="email" className="form-control" value={email} onChange={e => setEmail(e.currentTarget.value)} required/>
                                    </div>
                                    <div className="default-form-box">
                                        <label>Şifre<span className="text-danger">*</span></label>
                                        <input type="password" className="form-control" value={pass} onChange={e => setPass(e.currentTarget.value)} required minLength="8"/>
                                    </div>
                                    <div className="login_submit">
                                        <button className="theme-btn-one btn-black-overlay btn_md" type="submit">Kayıt Ol</button>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    )
}

export default RegisterArea
