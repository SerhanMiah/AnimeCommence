import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Card } from 'react-bootstrap';
import '../../Style/Product.css';
import { useNavigate } from 'react-router-dom';

function Products() {
  const [products, setProducts] = useState([]);
  const navigate = useNavigate();

  const handleProductClick = (id) => {
    navigate(`/products/${id}`);
  };

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get('http://localhost:5000/api/product');
        const products = response.data.$values || [];
        setProducts(products);
      } catch (error) {
        console.error('Error fetching data', error);
      }
    };

    fetchData();
  }, []);

  return (
    <div className="product-grid">
      <h1 className="w-100 text-center mb-4">Anime Products</h1>
      <div className="product-grid-container">
        {products.map((product) => (
          <div key={product.productId} className="product-item" onClick={() => handleProductClick(product.productId)}>
            <Card className="product-card">
              <div className="image-container">
                <Card.Img
                  className="product-image"
                  src={product.images && product.images.$values && product.images.$values.length > 0 ? product.images.$values[0] : 'defaultImage.jpg'}
                  alt={product.name}
                />
              </div>
              <Card.Body className="product-body">
                <div className="product-name">{product.name}</div>
                <div className="product-publisher">{product.publisher}</div>
                <div className="product-price">${product.price}</div>
                {!product.inStock && <div className="out-of-stock">Sold Out</div>}
              </Card.Body>
            </Card>
          </div>
        ))}
      </div>
    </div>
  );
}

export default Products;
