import React from 'react'
import Header from '../../components/Common/Header'
import Banner from '../../components/Common/Banner'
import OrderCompleted from '../../components/OrderCompleted'
import Footer from '../../components/Common/Footer'
const OrderComplete = () => {
    return (
        <>
            <Header />
            <Banner title="Siparişiniz Alındı" />
            <OrderCompleted />
            <Footer />
        </>
    )
}

export default OrderComplete