import React from 'react';
import '../styles/LoginPageStyle/Background.css';

import Login from '../components/Login';
import Banner from '../components/Banner';

function LoginPage() {
    return (
        <>
            <body className="background">
                <Banner />
                <Login />
            </body>
        </>
    );
}

export default LoginPage;