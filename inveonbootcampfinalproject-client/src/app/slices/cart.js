import Swal from "sweetalert2";
import { createSlice, createAsyncThunk } from '@reduxjs/toolkit'
import HttpService from "../../services/HttpService";
import userManager from "../../utils/userManager";

const initialState = {
  products: [],  //Sepette bulunan ürünleri tutan bir dizi.
  status: 'idle',  //Redux Toolkit'in async durumunu takip etmek için kullanılan bir durum.
  error: null  //Hata durumunda tutulan bir hata nesnesi.
}

const cartSlice = createSlice({
    name: 'cart', 
    initialState: initialState,
    reducers: {
        //sepete ürün eklemek için kullanılacak
        AddToCart: (state, action) => {
            let { product, count, size } = action.payload;
            console.log('action.payload: ', action.payload);
            let productInCart = state.products.find(item => item.productId === product.productId && item.size === product.size)
            try {
                if (productInCart) {
                    productInCart.quantity += count;
                }
                else {
                    state.products.push({...product, quantity: count, size: size});
                }
                
                
                Swal.fire(
                    {
                        title: 'Başarılı',
                        text: "Ürün sepete eklendi!",
                        icon: 'success',
                        showConfirmButton: false,
                        timer: 2000
                    }
                )
            }
            catch (e) {
                Swal.fire(
                    {
                        title: 'Başarısız oldum...',
                        text: "Ürün sepete eklenemedi :(",
                        icon: 'error',
                        showConfirmButton: false,
                        timer: 2000
                    }
                )
            }
        },
        showInCart: (state, action) => {  //Sepette görünen ürünleri eklemek için kullanılır.
            let { product, count, size } = action.payload;
            console.log('action.payload: ', action.payload);
            state.products.push({
                ...product,
                count: count, 
                size: size
            })
        },
        updateCart: (state, action) => {   //Sepet içindeki ürün miktarını günceller.

            let { val, id } = action.payload;
            state.carts.forEach(item => {
                if (item.id === parseInt(id)) {
                    item.quantity = val
                }
            })
        },
        removeFromCart: (state, action) => {   //Sepetten belirli bir ürünü kaldırır.
            let { productId, size } = action.payload;
            console.log('state.products: ', state.products);
            let filteredCart = state.products.filter(item => !(item.size === size && item.productId === productId))
            state.products= filteredCart
        },
        //sepeti komple silmek için
        clearCart: (state) => {
            state.products = [];
            state.status = 'idle';
        },
    },
    extraReducers(builder) {
        builder
          .addCase(getCart.pending, (state, action) => {
            state.status = 'loading'
          })
          .addCase(getCart.fulfilled, (state, action) => {
            state.status = 'succeeded'
            const {cartItems, products} = action.payload
            if (!!!cartItems || !cartItems.length) {
                return;
            }
            state.products = cartItems.map(item => {

                const product = products.find(product => product.productId === item.productId)
                return (
                    {
                        ...product,
                        productId: item.productId,
                        quantity: item.count,
                        size: item.size
                    }
                )
            });
          })
          .addCase(getCart.rejected, (state, action) => {
            state.status = 'failed'
            state.error = action.error.message
          })
      }
})
export default cartSlice.reducer
export const selectAllCartItems = state => state.cart.products  //Redux store'da bulunan tüm sepet ürünlerini seçer.
export const selectTotalCartCost = state => {  //Sepetin toplam maliyetini hesaplar.
    let cartTotal = state.cart.products?.reduce((totalPrice , product) => {
        totalPrice += product.price * product.quantity
        return totalPrice
    }, 0)
    return Number((cartTotal).toFixed(2))
}


export function addToCart(id, size, count) {  //Sepete ürün eklemek için kullanılan bir action creator.
    return async (dispatch, getState) => {
        // you can use api and something else here
        const state = getState();
        let product = null;
        const user = await userManager.getUser();
        if (!user) {
            Swal.fire(
                {
                    title: 'Üye Girişi',
                    text: "Lütfen üye girişi yapınız!",
                    icon: 'warning',
                    showConfirmButton: true
                }
            )
            return;
            }

        if (state.products.singleProduct?.productId === id) {
            product = state.products.singleProduct
        }
        else {
            product = state.products.products.find(prod => prod.productId === id)
        }

        const success = await HttpService.addToCart(id, size, count)

        if (success) {
            dispatch({ type: "cart/AddToCart", payload: { product: product, count: count, size: size } })
        }
        else {
            Swal.fire(
                {
                    title: 'Başarısız oldum...',
                    text: "Ürün sepete eklenemedi :(",
                    icon: 'error',
                    showConfirmButton: false,
                    timer: 2000
                }
            )
        }
    }
  }


export const getCart = createAsyncThunk('cart/getCartItems', async () => {
        const data = await HttpService.getCart();
        const products = await HttpService.getAllProducts();
        return {cartItems: data, products: products}
})

export function deleteFromCart(productId, size) {  //Sepetten ürün silmek için kullanılan bir action creator.
    return async (dispatch, getState) => {
        // you can use api and something else here
        const state = getState();

        const user = await userManager.getUser();
        if (!user) {
            Swal.fire(
                {
                    title: 'Üye Girişi',
                    text: "Lütfen üye girişi yapınız!",
                    icon: 'warning',
                    showConfirmButton: true
                }
            )
            return;
            }

        const success = await HttpService.deleteFromCart(productId, size)

        if (success) {
            dispatch({ type: "cart/removeFromCart", payload: { productId: productId, size: size } })
        }
        else {
            Swal.fire(
                {
                    title: 'Başarısız oldum...',
                    text: "Ürün sepetten silinemedi :(",
                    icon: 'error',
                    showConfirmButton: false,
                    timer: 2000
                }
            )
        }
    }
  }
