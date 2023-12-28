import axios from "axios";
import userManager from "../utils/userManager"
// const axios = require("axios");
import Swal from "sweetalert2";

class HttpService {
   // Sınıf, farklı servislerle iletişim kurmak için çeşitli Axios istemcilerini oluşturur. 
    constructor () {
        this.productsClient = axios.create({
            baseURL: 'http://localhost:5003/api'
        })

        this.cartClient = axios.create({
            baseURL: 'http://localhost:5004/api'
        })

        this.reviewsClient = axios.create({
            baseURL: 'http://localhost:5007/api'
        })

        this.favoritesClient = axios.create({
            baseURL: 'http://localhost:5008/api'
        })

        this.registerClient = axios.create({
            baseURL: 'http://localhost:5002/'
        })

        this.access_token = null;
        
        this.cartClient.interceptors.request.use(async (config) => {
            const user = await userManager.getUser();
            if (user) {
                this.access_token = user.access_token;
            }
            config.headers.Authorization =  this.access_token ? `Bearer ${this.access_token}` : '';
            return config;
        });
        // Axios istemcilerine interceptor'lar eklenmiştir. Bu interceptor'lar, her istek gönderilmeden önce belirli bir 
        // işlemi gerçekleştirmenizi sağlar. Bu durumda, kullanıcının kimlik bilgilerini alır ve her isteğin header'ına 
        // bu kimlik bilgilerini ekler.

        this.reviewsClient.interceptors.request.use(async (config) => {
            const user = await userManager.getUser();
            if (user) {
                this.access_token = user.access_token;
            }
            config.headers.Authorization =  this.access_token ? `Bearer ${this.access_token}` : '';
            return config;
        });

        this.favoritesClient.interceptors.request.use(async (config) => {
            const user = await userManager.getUser();
            if (user) {
                this.access_token = user.access_token;
            }
            config.headers.Authorization =  this.access_token ? `Bearer ${this.access_token}` : '';
            return config;
        });
        
    }

    async getAllProducts () {
        const response = await this.productsClient.get("products");
        if (response.status === 200) {
            return response.data.result;
        }
        else {
            throw new Error("Cannot get all products!");
        }
    }
    // getAllProducts: Tüm ürünleri getirir.
    // getProductById: Belirli bir ürünü kimlik doğrulama bilgileriyle getirir.

    async getProductById (id, access_token) {
        const config = {
            headers: { Authorization: `Bearer ${access_token}` }
        };
        const response = await this.productsClient.get(`products/${id}`, config);
        if (response.status === 200) {
            return response.data.result;
        }
        else {
            throw new Error("Cannot get all products!");
        }
    }

    async getAllProducts () {
        const response = await this.productsClient.get("products");
        if (response.status === 200) {
            return response.data.result;
        }
        else {
            throw new Error("Cannot get all products!");
        }
    }

    async addToCart (productId, size, count) {  //addToCart: Ürünü sepete ekler.

        const response = await this.cartClient.post("cart/AddProductToCart", {
            productId: productId, 
            size: size, 
            count: count
        });
        return (response.status === 200 && response.data.isSuccess)
    }

    async getCart () {  //getCart: Sepeti getirir.

        const response = await this.cartClient.get(`cart/GetCart`);
        if (response.status === 200) {
            return response.data.result;
        }
        else {
            throw new Error("Cannot get all products!");
        }
    }

    async getFavorites () {
        const response = await this.favoritesClient.get(`getFavorites`);
        if (response.status === 200) {
            return response.data;
        }
        else {
            throw new Error("Cannot get all products!");
        }
    }

    async addToFavorites (productId) {
        const response = await this.favoritesClient.post(`addFavorite`, {productId});
        if (response.status === 200) {
            return response.data.result;
        }
        else {
            throw new Error("Cannot add item to favorites!");
        }
    }

    async removeFromFavorites (productId) {
        const response = await this.favoritesClient.delete(`deleteFromFavorites`, {data: {productId}});
        if (response.status === 200) {
            return response.data.result;
        }
        else {
            throw new Error("Cannot delete item from favorites!");
        }
    }

    async deleteFromCart (productId, size) {  //deleteFromCart: Ürünü sepette siler.

        const response = await this.cartClient.delete(`cart/DeleteProductFromCart`,
            {data: {productId,size}}
        );
        return (response.status === 200 && response.data.isSuccess)
    }

    async getReviews (productId) {
        const response = await this.reviewsClient.get(`reviews/${productId}`);
        if (response.status === 200) {
            return response.data
        }
        else {
            throw new Error(`Cannot get reviews for product: ${productId}`);
        }
    }

    async postReview(productId, review) {
        try {
            const postData = {
                ProductId: productId,
                Comment: review.comment,
                Rating: review.rating
            };
    
            const response = await this.reviewsClient.post(`addReview`, postData);
            if (response.status === 200) {
                return response.data;
            } else {
                throw new Error(`Cannot post review for product: ${productId}`);
            }
        } catch (error) {
            console.error('Error posting review:', error.message);
            throw error;
        }
    }

    async createPayment(paymentInfo) {  //createPayment: Ödeme işlemini gerçekleştirir.

        const checkoutHeaderDto = {
            OrderTotal: paymentInfo.OrderTotal,
            FirstName: paymentInfo.firstName,
            LastName: paymentInfo.lastName,
            Phone: paymentInfo.phoneNumber,
            Email: paymentInfo.emailAddress,
            CardNumber: paymentInfo.cardNumber,
            CVV: paymentInfo.CVV,
            ExpiryMonth: paymentInfo.ExpiryMonth,
            ExpiryYear: paymentInfo.ExpiryYear
          };
        
        
        const response = await this.cartClient.post(`cartc/checkout`, checkoutHeaderDto);
        if (response.status === 200 && response.data.isSuccess) {
            return {isSuccess: true};
        } else {
            Swal.fire(
                {
                    title: 'Hata oluştu!',
                    text: response.data.errorMessages.join("\n"),
                    icon: 'error',
                    showConfirmButton: true,
                }
            )
            return {isSuccess: false, errorMessages: response.data.errorMessages};
        }
    }

    async setUserToken () {  //setUserToken: Kullanıcının erişim belirteci (access token) bilgisini ayarlar.

        const user = await userManager.getUser();
        this.access_token = user.access_token;
        this.cartClient.defaults.headers['Authorization'] = `Bearer ${this.access_token}`
    }

    async register (user, email, pass, firstName, lastName) {
        const postData = { 
            "ReturnUrl": "http://localhost:3000",
            "Username": user,
            "Email": email,
            "FirstName": firstName,
            "LastName": lastName,
            "Password": pass
        }
        let response;
        
        try {
            response = await this.registerClient.post("Account/Register", postData);
            if (response.status === 200) {
                return response;
            }
            else {
                return "Lütfen farklı bir kullanıcı adı deneyin!"
            }
        }
        catch (e) {
            return e
        }
    }
}

export default new HttpService();