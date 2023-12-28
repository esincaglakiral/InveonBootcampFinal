import React from 'react'
import { Link } from 'react-router-dom'
import img1 from '../../assets/img/product-image/product1.png'
const CartViewThree = () => {
    return (
        <>
            <section id="cart_area_three" className="ptb-100">
                <div className="container">
                    <div className="row">
                        <div className="col-lg-8 col-md-12 col-sm-12 col-12">
                            <div className="table_desc">
                                <div className="table_page table-responsive">
                                    <table>
                                        <thead>
                                            <tr>
                                                <th className="product_remove">Remove</th>
                                                <th className="product_thumb">Image</th>
                                                <th className="product_name">Product</th>
                                                <th className="product-price">Price</th>
                                                <th className="product_quantity">Quantity</th>
                                                <th className="product_total">Total</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td className="product_remove"><a href="#!"><i className="fa fa-trash"></i></a>
                                                </td>
                                                <td className="product_thumb">
                                                    <Link to="product-details-one/1">
                                                        <img src={img1} alt="img" />
                                                    </Link>
                                                </td>
                                                <td className="product_name">
                                                    <Link to="product-details-one/1">Handbag fringilla</Link>
                                                </td>
                                                <td className="product-price">$65.00</td>
                                                <td className="product_quantity">
                                                    <label>Quantity</label>
                                                    <input min="1" max="100" value="1" type="number" />
                                                </td>
                                                <td className="product_total">$130.00</td>
                                            </tr>
                                            <tr>
                                                <td className="product_remove"><a href="#!"><i className="fa fa-trash"></i></a>
                                                </td>
                                                <td className="product_thumb">
                                                    <Link to="product-details-one/1">
                                                        <img src={img1} alt="img" />
                                                    </Link>
                                                </td>
                                                <td className="product_name">
                                                    <Link to="product-details-one/1">Handbag fringilla</Link>
                                                </td>
                                                <td className="product-price">$65.00</td>
                                                <td className="product_quantity">
                                                    <label>Quantity</label>
                                                    <input min="1" max="100" value="1" type="number" />
                                                </td>
                                                <td className="product_total">$130.00</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <div className="cart_submit">
                                <button className="theme-btn-one btn-black-overlay btn_sm" type="submit">update cart</button>
                            </div>
                        </div>
                        <div className="col-lg-4 col-md-12">
                            <div className="coupon_code left">
                                <h3>Cart Total</h3>
                                <div className="total_cart_inner">
                                    <h5>Shipping:</h5>
                                    <form action="#!" id="total_cart_form_three">
                                        <label className="custom_boxed">Free Shipping <span className="rigth_cart">$0.00</span>
                                            <input type="radio" name="radio" />
                                            <span className="checkmark"></span>
                                        </label>
                                        <label className="custom_boxed">Standard <span className="rigth_cart">$30.00</span>
                                            <input type="radio" name="radio" />
                                            <span className="checkmark"></span>
                                        </label>
                                        <label className="custom_boxed">Express <span className="rigth_cart">$20.00</span>
                                            <input type="radio" name="radio" />
                                            <span className="checkmark"></span>
                                        </label>
                                        <h6 className="estimate_for_country">Estimate For Your Country</h6>
                                    </form>
                                    <div className="total_catr_three_bottom">
                                        <h5>Total Cart <span className="rigth_cart">$50.00</span></h5>
                                    </div>
                                    <div className="cart_submit">
                                        <Link to="/checkout-one" className="theme-btn-one btn-black-overlay btn_sm">Checkout</Link>
                                    </div>
                                </div>
                            </div>
                            <div className="coupon_code left bottom_code">
                                <h3>Coupon</h3>
                                <div className="coupon_inner">
                                    <p>Enter your coupon code if you have one.</p>
                                    <input className="mb-2" placeholder="Coupon code" type="text" />
                                    <button type="submit" className="theme-btn-one btn-black-overlay btn_sm">Apply coupon</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    )
}

export default CartViewThree