import { FC } from 'react'
import styles from './promotion-item.module.css'
import { IData } from 'src/interface.i'

interface _IData extends IData {
    // item_index: number
    // current_block_index: number
}
const PromotionItem: FC<_IData> = ({ img_src, text, title, id }) => {
    return (
        <div className={`${styles.item} ${id % 2 == 0 ? styles.odd : styles.even}`}>
            <div className={styles.poster_block}>
                <div className={styles.ice_cream_wrapper}>
                    <div className={styles.ice_cream_img}>
                        <img src="/ice-cream.png" alt="" />
                    </div>
                    <div className={`${styles.ice_cream_img} ${styles.down}`}>
                        <img src="/ice-cream.png" alt="" />
                    </div>
                </div>
                <div className={styles.poster_wrapper}>
                    <div className={styles.poster}>
                        <img src={img_src} alt="image no load" />
                    </div>
                </div>
            </div>
            <div className={styles.title_wrapper}>
                <h2 className={styles.title}>{title}</h2>
            </div>
            <div className={styles.text_wrapper}>
                <p className={styles.text}>{text}</p>
            </div>
            <div className={styles.conditions_wrapper}>
                <ul>
                    <li className={styles.conditions} style={{ fontSize: '1px' }}>
                        условия акции распространяются только на товары пупупу так так так условия акции распространяются только на товары пупупу так так так
                    </li>
                </ul>
            </div>
        </div>
    )
}
export default PromotionItem
