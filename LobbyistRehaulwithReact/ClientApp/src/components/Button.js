import react from 'react';
import { Link } from "react-router-dom";

import '../styles/MenuStyles/ButtonStyle.css';

function Button ({ link, icon, buttonMessage }) {
    return (
        <li className="button">
            <Link to={link} className="buttonLinks">
                <img src={icon} className="icon" />
                <text className="ButtonHeader">{buttonMessage}</text>
            </Link>
        </li>
    );
}

export default Button;