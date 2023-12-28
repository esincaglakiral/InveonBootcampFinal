import React from 'react'
import Header from '../../components/Common/Header'
import Banner from '../../components/Common/Banner'
import LeftSideBar from '../../components/Shop/LeftSibeBar'
import Footer from '../../components/Common/Footer'
import TopHeader from '../../components/Common/Header/TopHeader'

const ShopLeftSideBar = () => {
    return (
        <>
            <TopHeader />
            <Header />
            <Banner title="Shop" />
            <LeftSideBar />
            <Footer />
        </>
    )
}

export default ShopLeftSideBar