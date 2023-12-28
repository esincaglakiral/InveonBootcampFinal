import * as React from 'react';
import { connect, useDispatch } from 'react-redux';
import userManager from '../utils/userManager';
import { useEffect } from 'react';
import { useNavigate } from "react-router-dom";

// Bu kod parçası, bir kullanıcının kimlik doğrulama sağlayıcısından (örneğin, OpenID Connect sağlayıcısı) 
// gelen geri çağrıyı işleyen bir bileşeni içerir. Bu sayede kullanıcı, kimlik doğrulama işleminden sonra 
// yönlendirilecekleri bir sayfaya yönlendirilir. 

const CallbackPage = () => {
    const navigate = useNavigate();
    const dispatch = useDispatch();

    const successCallback = (user) => {
        console.log('successCallback');
        const redirectPath = user.state.path;
        let d = JSON.stringify(user);
        let f = JSON.parse(d);
        dispatch({ type: "user/login", payload: { user: f, status: true } })
        navigate(redirectPath);
        // dispatch fonksiyonu, kullanıcı başarıyla kimlik doğrulama geri çağrısını işlediğinde ve 
        // kullanıcı durumu güncellendiğinde Redux store'a bir eylem gönderir.
    };

    const errorCallback = (error) => {
        console.log('errorCallback');
        console.log(error);
        navigate('/');
    };

    useEffect(() => {
        userManager
            .signinRedirectCallback()
            .then(user => successCallback(user))
            .catch(error => errorCallback(error));
    });

    return <div>Loading...</div>;
};

export default connect()(CallbackPage);