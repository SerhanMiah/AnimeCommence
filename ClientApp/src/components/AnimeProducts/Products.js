import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Card, Button } from 'react-bootstrap';
import Rating from 'react-rating-stars-component';
import '../../Style/Product.css'
import { useNavigate } from 'react-router-dom';

function Products() {
  const [products, setProducts] = useState([]);
  const navigate = useNavigate();
  
  const handleProductClick = (id) => {
    navigate(`/products/${id}`);
  };

  const handleAddToCart = (productId) => {
    // Functionality to add the product to the cart
  };

  useEffect(() => {
    const fetchData = async () => {
      try {
        const { data } = await axios.get('http://localhost:5000/api/product');
        setProducts(data);
      } catch (error) {
        console.error('Error fetching data', error);
      }
    };

    fetchData();
  }, []);

  return (
    <div className="product-grid">
      <h1 className="w-100 text-center mb-4">Anime Products</h1>
      {products.map((id, product, index) => (
        <Card key={id} className="product-card" onClick={() => handleProductClick(id)}>
          <Card.Img variant="top" className="product-image" src={product.images ? product.images[0] : 'defaultImage.jpg'} />
          <Card.Body className="product-body">
            <Card.Title className="product-name">{product.name}</Card.Title>
            <Rating
              count={5}
              size={24}
              activeColor="#ffd700"
              value={product.rating}
              edit={false}
            />
            <p className="product-price"><strong>${product.price}</strong></p>
            <Button variant="primary" onClick={() => handleAddToCart(product.id)}>Add to Cart</Button>
          </Card.Body>
        </Card>
      ))}
    </div>
  );
}

export default Products;
