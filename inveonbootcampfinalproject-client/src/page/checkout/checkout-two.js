import React from 'react'
import Header from '../../components/Common/Header'
import TopHeader from '../../components/Common/Header/TopHeader'
import Banner from '../../components/Common/Banner'
import CheckOutTwos from '../../components/Checkout/CheckOutTwo'
import Footer from '../../components/Common/Footer'
const CheckoutTwo = () => {
    return (
        <>
            <TopHeader />
            <Header />
            <Banner title="Alışverişi Tamamla" />
            <CheckOutTwos />
            <Footer />
        </>
    )
}

export default CheckoutTwo