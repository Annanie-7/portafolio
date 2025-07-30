import { StrictMode } from "react";
import { createRoot } from "react-dom/client";    
import { createBrowserRouter } from 'react-router-dom';
import './index.css'
import App from './components/App.jsx'
import Navigation from './components/Navigation.jsx'
import Python from './components/Python.jsx'


const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
  },
  {
    path: "Python",
    element: <Python />,
  },
]);

createRoot(document.getElementById("root")).render(
  <StrictMode>
    <RouterProvider router={router} />
  </StrictMode>
);


