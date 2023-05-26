import react from 'react';
import '../styles/MenuStyles/ButtonStyle.css';

const Button = ({ link, icon, buttonMessage }) => {
    return (
        <>
            <div className="button">
                <a href={link} className="buttonLinks">
                    <img src={icon} className="icon" />
                    <label className="ButtonHeader">{buttonMessage}</label>
                </a>
            </div>
        </>
    );
}

export default Button;