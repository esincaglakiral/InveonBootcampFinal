import { BrowserRouter, Routes, Route } from "react-router-dom";
import loadable from "./components/Common/loadable";
import pMinDelay from "p-min-delay";
import Loader from "./components/Common/Loader";
import './assets/css/style.css';
import './assets/css/animate.min.css';
import './assets/css/color.css';
import Callback from "./page/callback";
import { loadUser } from "redux-oidc";
import { useSelector, useDispatch } from 'react-redux';
import { useEffect } from "react";
import userManager from "./utils/userManager";
import { userIsLoggedIn } from "./app/slices/user"
import HttpService from "./services/HttpService";
import { ccCart, getCart } from "./app/slices/cart";
import { getFavorites } from "./app/slices/favorites";
import { fetchProducts } from "./app/slices/product";
const Fashion = loadable(() => pMinDelay(import('./page/'), 250), { fallback: <Loader /> });
const Register = loadable(() => pMinDelay(import('./page/register'), 250), { fallback: <Loader /> });
const ProductDetailsTwos = loadable(() => pMinDelay(import('./page/Product/product-details-two'), 250), { fallback: <Loader /> });
const About = loadable(() => pMinDelay(import('./page/about'), 250), { fallback: <Loader /> });
const ContactTwo = loadable(() => pMinDelay(import('./page/Contact/contact-two'), 250), { fallback: <Loader /> });
const Login = loadable(() => pMinDelay(import('./page/login'), 250), { fallback: <Loader /> });
const Cart = loadable(() => pMinDelay(import('./page/cart/index'), 250), { fallback: <Loader /> });
const Favorites = loadable(() => pMinDelay(import('./page/Wishlist/index'), 250), { fallback: <Loader /> });

const ShopLeftSideBar = loadable(() => pMinDelay(import('./page/shop/shop-left-sidebar'), 250), { fallback: <Loader /> });
const OrderComplete = loadable(() => pMinDelay(import('./page/order/order-complete'), 250), { fallback: <Loader /> });
const CheckoutTwos = loadable(() => pMinDelay(import('./page/checkout/checkout-two'), 250), { fallback: <Loader /> });
const CustomerOrder = loadable(() => pMinDelay(import('./page/my-account/customer-order'), 250), { fallback: <Loader /> });
const CustomerAddress = loadable(() => pMinDelay(import('./page/my-account/customer-address'), 250), { fallback: <Loader /> });
const CustomerAccountDetails = loadable(() => pMinDelay(import('./page/my-account/customer-account-details'), 250), { fallback: <Loader /> });



function App() {
  
  const dispatch = useDispatch();
  
  const loggedIn = useSelector(userIsLoggedIn);
  const cartItems = useSelector(state => state.cart.products.length);
  let products = useSelector(state => state.products.products);

  useEffect(() => {
    dispatch(getCart())
    // Check if user exists in localStorage (saved by oidc-redux), log in if so
    if (!loggedIn) {
      userManager.getUser()
      .then(async data => {
        if (data) {
          if (data.expired) {
            await userManager.removeUser();
            const customState = { path: window.location };
            await userManager.signinRedirect({ state: customState });
          }
          // Doing this to make sure data is serializable, otherwise it errors.
          // i guess it has something to do with typescript typing.
          let d = JSON.stringify(data);
          let f = JSON.parse(d);
          dispatch({ type: "user/login", payload: { user: f, status: true} })
        }
        else {
          
          console.log("User does not exist in localStorage.")
        }
      })
    }
    else {
      // TODO check if user token is not expired here
    }

    setTimeout(() => {
      dispatch(getCart(products))
    }, 1000)
    setTimeout(() => {
      dispatch(getFavorites())
    }, 1000)
    setTimeout(() => {
      dispatch(fetchProducts())
    }, 1000)

  }, [dispatch])

  return (
    <div >
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Fashion />} />
          <Route path="/register" element={<Register />} />
          <Route path="/cart" element={<Cart />} />
          <Route path="/wishlist" element={<Favorites />} />
          <Route path="/callback" element={<Callback />} />

          <Route path="/login" element={<Login />} />
          <Route path="/product-details-two/:id" element={<ProductDetailsTwos />} />
          <Route path="/about" element={<About />} />
          <Route path="/contact" element={<ContactTwo />} />
          <Route path='/order-complete' element={<OrderComplete />} />
          <Route path="/checkout-two" element={<CheckoutTwos />} />
          <Route path="/my-account/customer-order" element={<CustomerOrder />} />
          <Route path="/my-account/customer-address" element={<CustomerAddress />} />
          <Route path="/my-account/customer-account-details" element={<CustomerAccountDetails />} />
          <Route path="/shop/shop-left-sidebar" element={<ShopLeftSideBar />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
