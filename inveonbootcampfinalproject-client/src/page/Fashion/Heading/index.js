import React from "react"

const Heading = (props) => {
    return(
        <>
        <div className="row">
            <div className="col-lg-12">
                <div className="center_heading">
                    <h2>{props.baslik}</h2>
                    <p>{props.altBaslik}</p>
                </div>
            </div>
        </div>
        </>
    )
}
export default Heading