import React from 'react'
import Header from '../components/Common/Header'
import Banner from '../components/Common/Banner'
import AboutComponent from '../components/About'
import Footer from '../components/Common/Footer'
import TopHeader from '../components/Common/Header/TopHeader'
const About = () => {
    return (
        <>
            <TopHeader />
            <Header />
            <Banner title="Hakkımızda" />
            <AboutComponent />
            <Footer />
        </>
    )
}

export default About