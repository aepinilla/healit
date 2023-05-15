import numpy as np
from scipy import stats

from src.settings import dummy_rri, dummy_rmssd

# def compute_excitement(timeseries):
rris = np.array(dummy_rri, dtype=np.float32)
rmssds = np.array(dummy_rmssd, dtype=np.float32)

zsore_rri = stats.zscore(rris)
zsore_rmssd = stats.zscore(rmssds)

excitement = (zsore_rri + zsore_rmssd) / 2

print('')