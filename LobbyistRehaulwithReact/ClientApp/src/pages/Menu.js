import React, { useState } from 'react';

import '../styles/MenuStyles/MenuStyle.css';

import Banner from '../components/Banner';
import Button from '../components/Button';

import BasicExample from '../components/BasicExample';

import MenuFooter from '../components/MenuFooter';

import HouseIcon from '../assets/HouseIcon_custom.png';
import RegisrationIcon from '../assets/Registration_icon_custom.png';
import ReportsIcon from '../assets/ReportsIcon_custom.png';
import EnpendatureReportsIcon from '../assets/ExpenditureReportsIcon_custom.png';
import EditInformationIcon from '../assets/EditInformationIcon_custom.png';
import RegistrationCertificateIcon from '../assets/RegistrationCertificateIcon_custom.png';
import ResetPasswordIcon from '../assets/ResetPasswordIcon_custom.png';
import SignOutIcon from '../assets/SignOutIcon_custom.png';

/* Find a way to implement Navbar functionality with the button component or use a new component entirely */
function Menu() {
    return (
        <>
            <div className="overallDiv">
                <Banner />
                <div className="buttonRow">

                    <BasicExample />

                </div>

                <MenuFooter />
            </div>
        </>
    );
}

export default Menu;