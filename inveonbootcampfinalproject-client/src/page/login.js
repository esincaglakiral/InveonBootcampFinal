import React from 'react'
import Header from '../components/Common/Header'
import Banner from '../components/Common/Banner'
import LoginArea from '../components/Login'
import Footer from '../components/Common/Footer'
import TopHeader from '../components/Common/Header/TopHeader'
const Login = () => {
    return (
        <>
            <TopHeader />
            <Header />
            <Banner title="Giriş Yap" />
            <LoginArea />
            <Footer />
        </>
    )
}

export default Login