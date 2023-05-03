import 'bootstrap/dist/css/bootstrap.css';
import './styles/LoginPageStyle/Background.css';
import React, { Component } from 'react';
import { createRoot } from 'react-dom/client';
import Login from './components/Login';
import Banner from './components/Banner';

const rootElement = document.getElementById('root');
const root = createRoot(rootElement);

root.render(
    <>
        <html>
            <Banner />
            <Login />
        </html>
    </>
);
