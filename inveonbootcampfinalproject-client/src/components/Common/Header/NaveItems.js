import React from "react";
import { Link } from "react-router-dom";

// Bu bileşen, MenuData dosyasından gelen verilere göre dinamik olarak menü öğelerini oluşturur. 
// Her bir alt menü öğesi, ayrı bir bağlantıya ve isme sahiptir.
// Bu sayede sitenin menüsü dinamik ve genişletilebilir bir yapıya sahiptir.
const NaveItems = (props) => {
    return(
        <>
            {
                <li className="has-drowdown">
                    <a href={props.item.href} className="main-menu-link">{props.item.name}
                    {
                        props.item.children && 
                        <i className="fa fa-angle-down"></i>
                    }

                    </a>
                        {
                            props.item.children &&
                            <ul className="sub-menu">
                                {props.item.children.map((subMenu,subMenuIndex)=> (
                                    <li key={subMenuIndex}>
                                        <Link to={subMenu.href}>{subMenu.name}</Link>
                                    </li>
                                ))}
                            </ul>
                        }
                </li>
            }
        </>
    )
}

export default NaveItems