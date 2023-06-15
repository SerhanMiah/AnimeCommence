import React from 'react';
import ReactDOM from 'react-dom';
import './index.css'; // Specific component styles
import './main.css'; // Global styles
import App from './App';
import 'bootstrap/dist/css/bootstrap.min.css';

const root = document.getElementById('root');
ReactDOM.createRoot(root).render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);
