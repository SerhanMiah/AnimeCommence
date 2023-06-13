import React, { Component } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Home from '../src/components/Home'
import Products from './components/AnimeProducts/Products';
import NavigationBar from './components/Navigation/NavigationBar';


export default class App extends Component {
  static displayName = App.name;

  render() {
    return (

      <Router>
      <div className="App">
        <NavigationBar />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/products" element={<Products />} />
          
          {/* <Route path="*" element={<NotFound />} /> */}
        </Routes>
     
      </div>
    </Router>

    );
  }
}
