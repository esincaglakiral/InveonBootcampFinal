import React from 'react'
const Cookie = (props) => {
    // Cookie bileşeni genellikle kullanıcıya çerez politikasını kabul etme veya reddetme seçeneği sunmak için kullanılır. 
    return (
        <>
            <div className="cookie-bar">
                <p>Sitemizi ve alışveriş deneyiminizi geliştirmek için çerezleri kullanıyoruz. Sitemizde gezinmeye devam ederek kabul etmiş olursunuz!
                    Çerez Politikamız.</p>
                <button onClick={props.accept} className="btn theme-btn-one bg-black btn_sm mr-2 ml-4">
                    onayla</button>
                <button onClick={props.cancel} className="btn theme-btn-one bg-black btn_sm ml-2">reddet</button>
            </div>
        </>
    )
}

export default Cookie