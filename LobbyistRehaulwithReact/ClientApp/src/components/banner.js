/* this is a template for a React.js 'component' */
import React, { Component } from 'react';
import '../styles/LoginPageStyle/BannerLogin.css';
import cityLogo from '../assets/CityLogoHorizontalWhite.png'; // Do it this way

export class Banner extends Component {
    static displayName = Banner.name;

    render() {
        return (
            <>
                <div className="header">
                    <div className="headerContent">
                        <div>
                            <a href="https://www.coralgables.com">
                                <img src={cityLogo} className="cityLogo" />
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
}
