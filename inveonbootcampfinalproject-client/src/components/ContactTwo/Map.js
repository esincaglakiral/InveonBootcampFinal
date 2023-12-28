import React from 'react'
import { GoogleMap, LoadScript } from '@react-google-maps/api';
const Map = () => {
    const mapStyles = {
        height: "21vh",
        width: "100%",
        margin: "0 0 0 0"
    };
    const defaultCenter = {
        lat: 41.8136822, lng: 28.5635596
    }
    return (
        <>
            <div className="col-lg-12">
                <div className="map_area">
                    <LoadScript>
                        <GoogleMap mapContainerStyle={mapStyles} zoom={10} center={defaultCenter}></GoogleMap>
                    </LoadScript>
                </div>
            </div>
        </>
    )
}
export default Map

// Google Haritalar API kullanılarak bir harita gösterir