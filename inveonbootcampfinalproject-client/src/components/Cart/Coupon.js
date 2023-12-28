import React from 'react'
import Swal from 'sweetalert2'

const Coupon = () => {
    return (
        <>
            <div className="col-lg-6 col-md-6">
                <div className="coupon_code left">
                    <h3>Kupon</h3>
                    <div className="coupon_inner">
                        <p>Kupon Kodu Giriniz</p>
                        <form onSubmit={(e) => { e.preventDefault(); Swal.fire('Error!!', 'Geçersiz Kupon Kodu', 'error') }}>
                            <input className="mb-2" placeholder="Coupon code" type="text" required />
                            <button type="submit" className="theme-btn-one btn-black-overlay btn_sm">Onayla</button>
                        </form>
                    </div>
                </div>
            </div>
        </>
    )
}

export default Coupon