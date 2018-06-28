import { Seller } from './Seller';
import { Buyer } from './Buyer';
export class Sale {
  public id: number;
  public sellerId: number;
  public Seller: Seller;
  public buyerId: number;
  public buyer: Buyer;
  public adress: string;
  public model: string;
  public width: number;
  public height: number; 
  public length: number; 
  public receivedForms: string; 
  public warrantyEndDate: Date;
  public invoicePrice: number;
  public ourSalePrice: number;
  public commission: number;
  public extraFormPrice: string;
  public description: string;
  public createDate: string;
  public createBy: string;
  public updateDate: Date;
  public updateBy: string;

}
