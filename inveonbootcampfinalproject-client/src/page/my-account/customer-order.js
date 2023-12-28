import React from 'react'
import Header from '../../components/Common/Header'
import Banner from '../../components/Common/Banner'
import Layout from '../../components/MyAccountDashboard/Layout'
import Order from '../../components/MyAccountDashboard/Order'
import Footer from '../../components/Common/Footer'
const CustomerOrder = () => {
    return (
        <>
            <Header />
            <Banner title="Müşteri Paneli" />
            <Layout>
                <Order />
            </Layout>
            <Footer />
        </>
    )
}

export default CustomerOrder
