import React from 'react'
import Header from '../../components/Common/Header'
import Banner from '../../components/Common/Banner'
import ContactTwoArea from '../../components/ContactTwo'
import Footer from '../../components/Common/Footer'
import TopHeader from '../../components/Common/Header/TopHeader'
const ContactTwo = () => {
    return (
        <>
            <TopHeader />
            <Header />
            <Banner title="Bize Ulaşın" />
            <ContactTwoArea />
            <Footer />
        </>
    )
}

export default ContactTwo