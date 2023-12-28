import React from 'react'
import { Link } from 'react-router-dom'
// import Img
import img from '../../assets/img/common/empty-cart.png'

const EmptyCart = () => {
    return (
        <>
            <section id="empty_cart_area" className="ptb-100">
                <div className="container">
                    <div className="row">
                        <div className="col-lg-6 offset-lg-3 col-md-6 offset-md-3 col-sm-12 col-12">
                            <div className="empaty_cart_area">
                                <img src={img} alt="img" />
                                <h2>SEPETİNİZ BOŞ</h2>
                                <Link to="/shop/shop-left-sidebar" className="btn btn-black-overlay btn_md">Alışverişe Devam</Link>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    )
}

export default EmptyCart
