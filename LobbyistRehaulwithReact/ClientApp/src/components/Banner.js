import React from 'react';
import "../styles/LoginPageStyle/Banner.css";
import CityLogo from "../assets/CityLogoHorizontalWhite.png";

function Banner() {

    return (
        <>
            <div className="header">
                <div className="headerContent">
                    <div>
                        <a href="https://www.coralgables.com">
                            <img src={CityLogo} alt="City Logo" className="cityLogo" />
                        </a>
                    </div>
                    <div>
                        <a href="https://www.coralgables.com/department/office-city-clerk" className="Clerktext">
                            <label className="Clerktext"><span>Back To City Clerk Homepage</span></label></a>
                    </div>
                </div>
            </div>
        </>
    );
}

export default Banner;