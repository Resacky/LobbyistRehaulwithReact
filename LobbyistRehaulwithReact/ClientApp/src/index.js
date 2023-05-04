import 'bootstrap/dist/css/bootstrap.css';
import React, { Component } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";

/* these are the pages, within React.js pages and components are the same thing */
import LoginPage from './Pages/LoginPage';
import Menu from './Pages/Menu';

const rootElement = document.getElementById('root');
const root = createRoot(rootElement);

root.render(
    <>
        <Router>
            <Routes>
                <Route path="/" element={<LoginPage />} />
                <Route path="/Homepage" element={<Menu />} />
            </Routes>
        </Router>
    </>
);
