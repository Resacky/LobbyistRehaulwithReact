import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import { createRoot } from 'react-dom/client';
import { Banner } from './components/banner.js';
import { Background } from './components/background.js';
import { Login } from './components/login.js';

const rootElement = document.getElementById('root');
const root = createRoot(rootElement);

root.render(
    <Background>
        <Banner />
        <Login />
        <div/>
    </Background>
);
