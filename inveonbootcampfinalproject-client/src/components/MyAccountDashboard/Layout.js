import React from 'react'
import Sidebar from './Sidebar'
const Layout = (props) => {
    return (
        <>
            <section id="my-account_area" className="ptb-100">
                <div className="container">
                    <div className="row">
                        <Sidebar />
                        <div className="col-sm-12 col-md-12 col-lg-9">
                            <div className="tab-content dashboard_content">
                                <div className="tab-pane fade show active" id="dashboard">
                                   {props.children}
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    )
}

export default Layout


// props.children, Layout bileşenine bir üst bileşen tarafından iletilen içeriği temsil eder. 
// Bu içerik, kullanıcının hesap yönetim sayfasının içeriğini içerir. Örneğin, AccountDetails, Address, Order gibi 
// bileşenler burada görünebilir. Bu düzen, kullanıcının sol kenar çubuğunu kullanarak farklı hesap sayfaları arasında 
// geçiş yapmasına ve her sayfanın özel içeriğini görmesine olanak tanır.