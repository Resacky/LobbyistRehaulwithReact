import React from 'react';
import '../styles/MenuStyles/MenuStyle.css';

import Banner from '../components/Banner';
import Button from '../components/Button';
import MenuFooter from '../components/MenuFooter';

import HouseIcon from '../assets/HouseIcon_custom.png';
import RegisrationIcon from '../assets/Registration_icon_custom.png';
import ReportsIcon from '../assets/ReportsIcon_custom.png';
import EnpendatureReportsIcon from '../assets/ExpenditureReportsIcon_custom.png';
import EditInformationIcon from '../assets/EditInformationIcon_custom.png';
import RegistrationCertificateIcon from '../assets/RegistrationCertificateIcon_custom.png';
import ResetPasswordIcon from '../assets/ResetPasswordIcon_custom.png';
import SignOutIcon from '../assets/SignOutIcon_custom.png';

function Menu() {
    return (
        <>
            <div className="overallDiv">
                <Banner />
                <div className="buttonRow">
                    <Button link="" icon={HouseIcon} buttonMessage="Home" />
                    <Button link="" icon={RegisrationIcon} buttonMessage="Registration" />
                    <Button link="" icon={ReportsIcon} buttonMessage="Reports" />
                    <Button link="" icon={EnpendatureReportsIcon} buttonMessage="Expenditure Reports" />
                    <Button link="" icon={EditInformationIcon} buttonMessage="Edit Information" />
                    <Button link="" icon={RegistrationCertificateIcon} buttonMessage="Registration Certificate" />
                    <Button link="" icon={ResetPasswordIcon} buttonMessage="Reset Password" />
                    <Button link="" icon={SignOutIcon} buttonMessage="Sign Out" />
                </div>

                <></>

                <MenuFooter />
            </div>
        </>
    );
}

export default Menu;