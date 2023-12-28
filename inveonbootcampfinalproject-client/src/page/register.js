import React from 'react'
import Header from '../components/Common/Header'
import Banner from '../components/Common/Banner'
import RegisterArea from '../components/Register'
import Footer from '../components/Common/Footer'
import TopHeader from "../components/Common/Header/TopHeader";

const Register = () => {
    return (
        <>
            <TopHeader />
            <Header />
            <Banner title="Kayıt Ol" />
            <RegisterArea />
            <Footer />
        </>
    )
}

export default Register