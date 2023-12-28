import React from 'react'
const Address = () => {
    //Address bileşeni, kullanıcının fatura adresini ve teslimat adresini görüntülediği bir sayfa görünümünü temsil eder
    return (
        <>
            <div className="row">
                <div className="col-lg-6">
                    <div className="myaccount-content">
                        <h4 className="title">Fatura Adresi</h4>
                        <div className="billing_address">
                            <h5><strong>Esin Çağla Kıral</strong></h5>
                            <p>
                            Yahya Kemal Mah.<br /> Kağıthane / İstanbul
                            </p>
                            <p>Mobil: (530) 123-456789</p>
                            <button className="theme-btn-one bg-black btn_sm mt-4">Düzenle</button>
                        </div>
                    </div>
                </div>
                <div className="col-lg-6">
                    <div className="myaccount-content">
                        <h4 className="title">Teslimat Adresi</h4>
                        <div className="billing_address">
                            <h5><strong>Esin Çağla Kıral</strong></h5>
                            <p>
                             Yahya Kemal Mah.	 <br /> Kağıthane / İstanbul
                            </p>
                            <p>Tel: (212) 200-111-1111</p>
                            <button  className="theme-btn-one bg-black btn_sm mt-4">Düzenle</button>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default Address
