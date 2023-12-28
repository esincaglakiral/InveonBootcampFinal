import React from 'react'
import TotalCart from './TotalCart'
import { Link } from 'react-router-dom'
import { useDispatch, useSelector } from "react-redux";
import img from '../../assets/img/common/empty-cart.png'
import Swal from 'sweetalert2';

const CartViewTwo = () => {

    let dispatch = useDispatch();
    let carts = useSelector((state) => state.products.carts);
    // Remove Product
    const rmProduct = (id) => {
        dispatch({ type: "cart/removeCart", payload: { id } });
    }
    // Clear Cart
    const clearCarts = () => {
        dispatch({ type: "cart/clearCart" });
    }
    // Cart Val Update
    const cartValUpdate = (val, id) => {
        dispatch({ type: "cart/updateCart", payload: { val, id } });
    }
    return (
        <>
            {carts.length
                ?
                <section id="cart_area_two" className="ptb-100">
                    <div className="container">
                        <div className="row">
                            <div className="col-lg-12 col-md-12 col-sm-12 col-12">
                                <div className="table_desc">
                                    <div className="table_page table-responsive">
                                        <table>
                                            <thead>
                                                <tr>
                                                    <th className="product_thumb">Image</th>
                                                    <th className="product_name">Product</th>
                                                    <th className="product-price">Price</th>
                                                    <th className="product_quantity">Quantity</th>
                                                    <th className="product_total">Total</th>
                                                    <th className="product_remove">Remove</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                {carts.map((data, index) => (
                                                    <tr key={index}>
                                                        <td className="product_thumb">
                                                            <Link to={`/product-details-one/${data.id}`}>
                                                                <img src={data.img} alt="img" />
                                                            </Link>
                                                        </td>
                                                        <td className="product_name">
                                                            <Link to={`/product-details-one/${data.id}`}> {data.title}</Link>
                                                        </td>
                                                        <td className="product-price">${data.price}.00</td>
                                                        <td className="product_quantity">
                                                            <div className="plus-minus-input">
                                                                <div className="input-group-button">
                                                                    <button type="button" className="button" onClick={e => cartValUpdate((data.quantity || 2) - 1, data.id)}>
                                                                        <i className="fa fa-minus" aria-hidden="true"></i>
                                                                    </button>
                                                                </div>
                                                                <input type="number" id="cart_val" onChange={e => cartValUpdate(e.currentTarget.value, data.id)} value={data.quantity || 1} />
                                                                <div className="input-group-button">
                                                                    <button type="button" className="button" onClick={e => cartValUpdate((data.quantity || 1) + 1, data.id)}>
                                                                        <i className="fa fa-plus" aria-hidden="true"></i>
                                                                    </button>
                                                                </div>
                                                            </div>
                                                        </td>
                                                        <td className="product_total">${data.price * (data.quantity || 1)}.00</td>
                                                        <td className="product_remove"><a href="#!" onClick={() => rmProduct(data.id)} style={{ 'cursor': 'pointer' }}><i className="fa fa-trash text-danger"></i></a></td>
                                                    </tr>
                                                ))}

                                            </tbody>
                                        </table>
                                    </div>
                                    <div className="cart_submit">
                                        <button className="theme-btn-one btn-black-overlay btn_sm" type="button" onClick={() => clearCarts()}>Clear cart</button>
                                    </div>
                                </div>
                                <div className="coupon_inner_two">
                                    <form onSubmit={(e) => { e.preventDefault(); Swal.fire('Error!!', 'Invalid Cuppon Code', 'error') }}>
                                        <input className="mb-2" placeholder="Coupon code" type="text" required />
                                        <button type="submit" className="theme-btn-one btn-black-overlay btn_sm">Apply coupon</button>
                                    </form>
                                </div>
                            </div>
                            <TotalCart fullGrid={"fullGrid"} />
                        </div>
                    </div>
                </section>
                : <section id="empty_cart_area" className="ptb-100">
                    <div className="container">
                        <div className="row">
                            <div className="col-lg-6 offset-lg-3 col-md-6 offset-md-3 col-sm-12 col-12">
                                <div className="empaty_cart_area">
                                    <img src={img} alt="img" />
                                    <h2>YOUR CART IS EMPTY</h2>
                                    <h3>Sorry Mate... No Item Found Inside Your Cart!</h3>
                                    <Link to="/shop/shop-left-sidebar" className="btn btn-black-overlay btn_sm">Continue Shopping</Link>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            }
        </>
    )
}

export default CartViewTwo