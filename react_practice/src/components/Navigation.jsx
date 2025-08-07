import { Link } from "react-router-dom";
import { Outlet } from "react-router-dom";

function Navigation(){
    const sections = ["React","Python","C#","C++","Java","Ruby","Swift","Rust","Kotlin"];

    const sectionList = sections.map((section) => <div className='navDiv' key={section}><Link className="navButton" key={section + "button"} to={section}>{section}</Link></div>)

    return(
        <>
            <div className='navigation'>   
                {sectionList}
            </div>
            <div>
                <Outlet />
            </div>
        </>

    )
}


export default Navigation