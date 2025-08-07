import App from "./App";
import Navigation from "./Navigation";
import Python from './Python.jsx'

const routes = [
  {
    path: "/",
    element: <Navigation />,
    children: [
      { index: true, element: <App /> },
      { path: "React", element: <App /> },
      { path: "Python", element: <Python /> }
    ]
  },
  
];

export default routes;
