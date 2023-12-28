import React from 'react'
import SkillBar from 'react-skillbars';

const skills = [
    { type: "UI/UX", level: 85 },
    { type: "FİKİR", level: 75 },
    { type: "PROJE", level: 55 },
];

const colors = {
    "bar": "#f798378a",
    "title": {
        "text": "#fff",
        "background": "#f79837"
    }
}

const Functionality = () => {
    return (
        <>
            <section id="about_progressbar" className="ptb-100">
                <div className="container">
                    <div className="row">
                        <div className="col-lg-6">
                            <div className="about_progressbar_content">
                                <h2>İşlevsellik mükemmellikle buluşuyor</h2>
                                <p>Günümüzün ve çağında, tasarımın önemi, izleyicilerinizi hareket ettirmek ve cezbetmek için çarpıcı görseller yaratma sanatının önemi küçümsenemez.</p>
                                <p>Marka Ekim 2021'de kuruldu ve o zamandan beri "herkes modanın güzelliğinden faydalanabilir" felsefesini benimsedi. İşi dünya çapında 220'den fazla ülke ve bölgeyi kapsamaktadır.</p>
                            </div>
                        </div>
                        <div className="col-lg-6">
                            <div className="custom-progress m-t-40">
                                <SkillBar skills={skills} height={40} colors={colors} />
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    )
}

export default Functionality
