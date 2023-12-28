import React from 'react'
import Header from '../../components/Common/Header'
import Banner from '../../components/Common/Banner'
import Layout from '../../components/MyAccountDashboard/Layout'
import AccountDetails from '../../components/MyAccountDashboard/AccountDetails'
import Footer from '../../components/Common/Footer'
const CustomerAccountDetails = () => {
    return (
        <>
             <Header />
            <Banner title="Müşteri Ekranı" />
            <Layout>
                <AccountDetails />
            </Layout>
            <Footer />
        </>
    )
}

export default CustomerAccountDetails
