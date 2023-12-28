import React from 'react'
import Header from '../../components/Common/Header'
import Banner from '../../components/Common/Banner'
import Footer from '../../components/Common/Footer'
import WishArea from '../../components/Wishlist'

const Favorites = () => {
    return (
        <>
            <Header />
            <Banner title="Favoriler" />
            <WishArea />
            <Footer />

        </>
    )
}

export default Favorites