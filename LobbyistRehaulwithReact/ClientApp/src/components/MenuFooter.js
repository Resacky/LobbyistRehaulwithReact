import react from 'react';

import '../styles/MenuStyles/MenuFooterStyle.css';

function MenuFooter() {
    return (
        <>
            <div className="footer">
                <p className="footerText">
                    Pursuant to Ordinance <a href="https://evogov.s3.amazonaws.com/media/91/media/127667.pdf">2017-44</a>, a lobbyist is defined as an individual, corporation, partnership, or other legal entity employed or retained whether paid or not, by a principal who seeks to encourage the approval, disapproval, adoption, repeal, passage, defeat, or modifications of (a) any ordinance, resolution, action or decision of any City Commissioner; (b) any action, decision, recommendation of the City Manager, any city board or committee, including but not limited to Quasi-Judicial, Advisory Board, Trust, Authority, or Council; or (c) any action, decision or recommendation of city personnel during the time period of the entire decision-making process on the action, decision or recommendation which foreseeably will be heard or reviewed by the City Commission, or a city board or committee, including but not limited to Quasi-Judicial, Advisory Board, Trust, Authority, or Council. The above referenced section of our City Code states that all lobbyists shall, before engaging in lobbying activities, register annually with the City Clerk’s Office.
                </p>
                <p className="footerText"><strong>ANNUAL REPORT:</strong> On October 1st of each year, you are required to submit online all lobbying expenditures in excess of $25.00 for the preceding calendar year. A statement is not required if there are no expenditures.</p>
                <p className="footerText">
                    <strong>ANNUAL LOBBYIST REGISTRATION FEE:</strong> A Registration of $250.00 is required per principal representative.
                </p>
                <p className="footerText"><strong>NOTICE OF WITHDRAWAL:</strong> If you discontinue representing a client, please submit a withdrawal on the online portal.</p>
            </div>
        </>
    );
}

export default MenuFooter;