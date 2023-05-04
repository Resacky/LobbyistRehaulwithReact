import React from 'react';
import Login from '../components/Login';
import Banner from '../components/Banner';

import '../styles/LoginPageStyle/Background.css';

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