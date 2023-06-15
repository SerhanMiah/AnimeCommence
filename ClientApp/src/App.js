import React, { Component } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Home from '../src/components/Home'
import Products from './components/AnimeProducts/Products';
import NavigationBar from './components/Navigation/NavigationBar';
import Footer from './components/Navigation/Footer';
import ProductDetail from './components/AnimeProducts/ProductDetail';
import Register from './components/Authorization/Register';
import Login from './components/Authorization/Login';
import Profile from './components/Authorization/Profile';
import ShouenManga from './components/AnimeProducts/GenreProducts';


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
          <Route path="/products/:id" element={<ProductDetail />} />

          <Route path="/products/:genre" element={<ShouenManga />} />


          {/* Profile */}
          <Route path="/register" element={<Register />} />
          <Route path="/login" element={<Login />} />
          <Route path="/profile" element={<Profile />} />



          {/* <Route path="*" element={<NotFound />} /> */}
        </Routes>
        <Footer />
      </div>
    </Router>

    );
  }
}
